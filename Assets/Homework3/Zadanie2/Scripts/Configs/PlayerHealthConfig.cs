using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlayerConfig/PlayerHealthConfig", fileName = "PlayerConfig")]
public class PlayerHealthConfig : ScriptableObject
{
    [SerializeField, Range(1, 100)] private int playerHealth;
    [SerializeField, Range(2, 5)] private int healthMultiplier;
    public int PlayerHealth => playerHealth;
    public int HealthMultiplier => healthMultiplier;
}
