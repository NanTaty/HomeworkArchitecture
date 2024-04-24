using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    private float _timer;
    private bool _isTimerOver;
    public event Action OnTimerOver; 

    public Timer(float timer)
    {
        _timer = timer;
        _isTimerOver = false;
    }

    public void TimerUpdate()
    {
        if (_isTimerOver)
            return;
        
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            OnTimerOver?.Invoke();
            _isTimerOver = true;
        }
    }
}
