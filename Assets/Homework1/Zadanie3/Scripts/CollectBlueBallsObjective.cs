using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CollectBlueBallsObjective : IObjective
{
    private IEnumerable<Ball> _blueBalls;

    public CollectBlueBallsObjective(IEnumerable<Ball> balls)
    {
        _blueBalls = balls;
    }

    public void CheckForWin(List<Ball> balls)
    {
        if (_blueBalls.Count() == balls.Count(ball => ball is BlueBall))
        {
            Debug.Log("You won!");
        }
    }
}
