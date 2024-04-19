using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private WeaponHandler _weaponHandler;

    private void Awake()
    {
        _weaponHandler = GetComponentInChildren<WeaponHandler>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _weaponHandler.CurrentWeapon.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _weaponHandler.CurrentWeapon.Reload();
        }
    }
}
