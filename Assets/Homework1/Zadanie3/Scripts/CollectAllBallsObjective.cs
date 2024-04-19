using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CollectAllBallsObjective : IObjective
{
    private List<Ball> _balls;

    public CollectAllBallsObjective(List<Ball> balls)
    {
        _balls = balls;
    }
    
    public void CheckForWin(List<Ball> balls)
    {
        if (_balls.Count == balls.Count)
        {
            Debug.Log("You won!");
        }
    }
}
