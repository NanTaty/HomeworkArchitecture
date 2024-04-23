using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected Transform shootPos;
    [SerializeField, Range(1, 30)] protected int bulletCount;
    [SerializeField] protected Transform bulletPrefab;
    protected int _initialBulletCount;

    public virtual void Shoot() {}

    public virtual void Reload() {}
}
