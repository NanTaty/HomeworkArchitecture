using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBulletsWeapon : Weapon
{
    public override void Shoot()
    {
        Instantiate(bulletPrefab, shootPos.position, shootPos.rotation);
    }

    public override void Reload(){}
}
