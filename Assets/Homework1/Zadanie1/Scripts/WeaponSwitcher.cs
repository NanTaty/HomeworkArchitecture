using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private List<Weapon> _weapons;
    private Weapon _currentWeapon;

    public Weapon CurrentWeapon => _currentWeapon;

    private void Start()
    {
        ChooseWeapon(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChooseWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChooseWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChooseWeapon(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChooseWeapon(3);
        }
    }

    private void ChooseWeapon(int index)
    {
        if (index > _weapons.Count || index < 0)
        {
            index = 0;
        }
        if (_currentWeapon != null)
        {
            _currentWeapon.gameObject.SetActive(false);
        }
        _currentWeapon = _weapons[index];
        _currentWeapon.gameObject.SetActive(true);
    }
}
