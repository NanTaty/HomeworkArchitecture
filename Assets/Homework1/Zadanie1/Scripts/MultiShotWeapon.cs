using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiShotWeapon : Weapon
{
    private const int BurstBulletCount = 3;
    private bool _canShoot = true;
    [SerializeField] private Transform _secondShootPos;
    [SerializeField] private Transform _thirdShootPos;
    [SerializeField] private List<Transform> shootPositions;

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
        ShootBurst();
    }
    
    public override void Reload()
    {
        bulletCount = _initialBulletCount;
        _canShoot = true;
    }

    private void ShootBurst()
    {
        for (int i = 0; i < shootPositions.Count; i++)
        {
            Instantiate(bulletPrefab, shootPositions[i].position, shootPositions[i].rotation);
            bulletCount--;
            if (bulletCount <= 0)
            {
                _canShoot = false;
                break;
            }
        }
    }
    
}
