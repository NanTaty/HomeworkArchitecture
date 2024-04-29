using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    private int _playerLevel;

    private int _experience;

    private int _newLevelExpCap;

    public int Level => _playerLevel;

    public event Action<int> OnPlayerLevelChanged;

    public void InitializeLevel(int playerLevel, int newLevelExpCap)
    {
        _playerLevel = playerLevel;
        _newLevelExpCap = newLevelExpCap;
        OnPlayerLevelChanged?.Invoke(_playerLevel);
    }

    public void IncreaseExperience(int experience)
    {
        _experience += experience;
        if (_experience >= _newLevelExpCap)
        {
            _experience = 0;
            _playerLevel += 1;
            OnPlayerLevelChanged?.Invoke(_playerLevel);
        }
    }
}
