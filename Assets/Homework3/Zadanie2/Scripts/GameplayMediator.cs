using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayMediator : IDisposable
{
    private PlayerHUD _playerHUD;
    private PlayerHealth _playerHealth;
    private PlayerLevel _playerLevel;
    private DefeatPanel _defeatPanel;
    private Player _player;

    public GameplayMediator(PlayerHUD playerHUD, Player player, DefeatPanel defeatPanel)
    {
        _player = player;
        _playerHealth = _player.PlayerHealth;
        _playerLevel = _player.PlayerLevel;
        _playerHUD = playerHUD;
        _defeatPanel = defeatPanel;
        
        _playerHealth.OnPlayerDied += PlayerHealth_OnPlayerDied;
        _playerLevel.OnPlayerLevelChanged += PlayerLevelOnPlayerLevelChanged;
        _playerHealth.OnPlayerHealthChanged += PlayerHealth_OnPlayerHealthChanged;
        
        UpdateStartHUD();
    }
    
    public void Dispose()
    {
        _playerHealth.OnPlayerDied -= PlayerHealth_OnPlayerDied;
        _playerLevel.OnPlayerLevelChanged -= PlayerLevelOnPlayerLevelChanged;
        _playerHealth.OnPlayerHealthChanged -= PlayerHealth_OnPlayerHealthChanged;
    }

    private void UpdateStartHUD()
    {
        _playerHUD.UpdateHealth(_playerHealth.Health);
        _playerHUD.UpdateLevel(_playerLevel.Level);
    }

    private void PlayerHealth_OnPlayerHealthChanged(int health)
    {
        _playerHUD.UpdateHealth(health);
    }

    private void PlayerLevelOnPlayerLevelChanged(int level)
    {
        _playerHUD.UpdateLevel(level);
    }
    

    private void PlayerHealth_OnPlayerDied()
    {
        _defeatPanel.Show();
        _playerHUD.Hide();
    }

    public void RestartLevel()
    {
        _defeatPanel.Hide();
        _playerHUD.Show();
        _player.InitializePlayer();
    }

    
}
