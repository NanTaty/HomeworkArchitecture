using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int _playerHealth;
    private int _maxHealth;
    private int _healthMultiplier;
    private PlayerLevel _playerLevel;
    public int Health => _playerHealth;

    public event Action OnPlayerDied;
    public event Action<int> OnPlayerHealthChanged;

    public void InitializeHealth(int health, int healthMultiplier)
    {
        _playerLevel = GetComponent<PlayerLevel>();
        _playerLevel.OnPlayerLevelChanged += PlayerLevel_OnPlayerLevelChanged;

        _maxHealth = health;
        _playerHealth = _maxHealth;
        _healthMultiplier = healthMultiplier;
        OnPlayerHealthChanged?.Invoke(_playerHealth);
    }
    
    private void PlayerLevel_OnPlayerLevelChanged(int obj)
    {
        _maxHealth *= _healthMultiplier;
        _playerHealth = _maxHealth;
        OnPlayerHealthChanged?.Invoke(_playerHealth);
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            return;
        
        _playerHealth -= damage;
        
        if (_playerHealth <= 0)
        {
            _playerHealth = 0;
            OnPlayerDied?.Invoke();
            gameObject.SetActive(false);
        }
        
        OnPlayerHealthChanged?.Invoke(_playerHealth);
    }
}
