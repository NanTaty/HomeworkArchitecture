using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
    private WeaponSwitcher _weaponSwitcher;

    private void Awake()
    {
        _weaponSwitcher = GetComponentInChildren<WeaponSwitcher>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _weaponSwitcher.CurrentWeapon.Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _weaponSwitcher.CurrentWeapon.Reload();
        }
    }
}
