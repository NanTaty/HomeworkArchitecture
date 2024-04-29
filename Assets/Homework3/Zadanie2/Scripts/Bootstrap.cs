using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private PlayerHUD _playerHUD;
    [SerializeField] private DefeatPanel _defeatPanel;
    private GameplayMediator _gameplayMediator;

    private void Awake()
    {
        player.InitializePlayer();
        _gameplayMediator = new GameplayMediator(_playerHUD, player, _defeatPanel);
        _defeatPanel.Initialize(_gameplayMediator);
    }
    
    
    //Просто для теста системы
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.PlayerHealth.TakeDamage(10);
            player.PlayerLevel.IncreaseExperience(100);
        }
    }
}
