using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IPickable
{
    [SerializeField] private BallColors _ballColor;

    public BallColors BallColor => _ballColor;
    public Ball PickableBall => this;

    public void Pick()
    {
        gameObject.SetActive(false);
    }
}
