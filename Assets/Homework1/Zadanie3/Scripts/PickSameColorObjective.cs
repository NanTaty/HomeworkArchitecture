using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSameColorObjective : Objective
{

    private BallColors _ballColor;

    public PickSameColorObjective(List<Ball> balls)
    {
        _balls = balls;
    }

    public override bool AddBallColorToList(IPickable pickable, List<Ball> characterBalls)
    {
        if (characterBalls.Count == 0)
        {
            _ballColor = pickable.BallColor;
            pickable.Pick();
            return true;
        }
        if (_ballColor == pickable.BallColor)
        {
            pickable.Pick();
            return true;
        }
        Debug.Log(_ballColor);
        return false;
        
    }

    public override void CheckForWin(List<Ball> characterBalls)
    {
        int ballColorCount = 0;
        foreach (var ball in _balls)
        {
            if (ball.BallColor == _ballColor)
            {
                ballColorCount++;
            }
        }

        if (characterBalls.Count == ballColorCount)
        {
            Debug.Log("You won!");
        }
    }
}
