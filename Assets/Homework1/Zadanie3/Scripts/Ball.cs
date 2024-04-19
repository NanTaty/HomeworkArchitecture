using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBallPicker ballPicker))
        {
            ballPicker.PickBall(this);
            gameObject.SetActive(false);
        }
    }
}
