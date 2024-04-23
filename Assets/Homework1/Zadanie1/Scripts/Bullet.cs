using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const int DestroyTime = 5;
    [SerializeField] private float speed;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(DestroyTime);
        Destroy(gameObject);
    }
}
