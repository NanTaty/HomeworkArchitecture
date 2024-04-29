using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlayerConfig/PlayerLevelConfig", fileName = "PlayerConfig")]
public class PlayerLevelConfig : ScriptableObject
{
    [SerializeField] private int playerLevel;
    [SerializeField] private int playerExpCap;
    
    private void OnValidate()
    {
        if (playerLevel <= 0)
        {
            playerLevel = 1;
        }

        if (playerExpCap <= 0)
        {
            playerExpCap = 1;
        }
    }

    public int PlayerLevel => playerLevel;
    public int PlayerExpCap => playerExpCap;
}
