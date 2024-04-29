using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerHealthConfig playerHealthConfig;
    [SerializeField] private PlayerLevelConfig playerLevelConfig;
    private PlayerHealth _playerHealth;
    private PlayerLevel _playerLevel;

    public PlayerHealth PlayerHealth => _playerHealth;
    public PlayerLevel PlayerLevel => _playerLevel;
    

    public void InitializePlayer()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerLevel = GetComponent<PlayerLevel>();
        
        _playerHealth.InitializeHealth(playerHealthConfig.PlayerHealth, playerHealthConfig.HealthMultiplier);
        _playerLevel.InitializeLevel(playerLevelConfig.PlayerLevel, playerLevelConfig.PlayerExpCap);
    }
}
