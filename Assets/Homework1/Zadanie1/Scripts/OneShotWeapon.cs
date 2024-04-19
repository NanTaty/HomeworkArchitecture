using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotWeapon : Weapon
{
    private bool _canShoot = true;

    private void Start()
    {
        _initialBulletCount = bulletCount;
    }

    public override void Shoot()
    {
        if (_canShoot == false)
        {
            return;
        }
        Instantiate(bulletPrefab, shootPos.position, shootPos.rotation);
        bulletCount--;
        if (bulletCount <= 0)
            _canShoot = false;
    }

    public override void Reload()
    {
        bulletCount = _initialBulletCount;
        _canShoot = true;
    }
}
