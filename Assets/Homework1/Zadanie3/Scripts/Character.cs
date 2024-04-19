using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IBallPicker
{
    [SerializeField] private List<Ball> _balls;

    public event Action OnBallPicked;

    private void Start()
    {
        _balls = new List<Ball>();
    }

    public List<Ball> Balls => _balls;
    public void PickBall(Ball ball)
    {
        _balls.Add(ball);
        OnBallPicked?.Invoke();
    }
}
