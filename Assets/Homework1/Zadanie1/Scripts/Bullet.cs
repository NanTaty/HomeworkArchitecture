using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const int DestroyTime = 5;
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
        Destroy(gameObject, DestroyTime);
    }
}
