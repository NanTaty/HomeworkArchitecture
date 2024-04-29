using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private Text playerLevelText;
    [SerializeField] private Text playerHealthText;

    public void UpdateLevel(int level)
    {
        playerLevelText.text = "Level: " + level;
        Debug.Log(level);
    }
    public void UpdateHealth(int health)
    {
        playerHealthText.text = "Health: " + health;
    }

    public void Hide() => gameObject.SetActive(false);

    public void Show() => gameObject.SetActive(true);
}
