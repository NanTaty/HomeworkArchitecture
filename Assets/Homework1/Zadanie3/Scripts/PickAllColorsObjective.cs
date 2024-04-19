using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAllColorsObjective : Objective
{
    public PickAllColorsObjective(List<Ball> balls)
    {
        _balls = balls;
    }
    public override bool AddBallColorToList(IPickable pickable, List<Ball> characterBalls)
    {
        pickable.Pick();
        return true;
    }

    public override void CheckForWin(List<Ball> characterBalls)
    {
        if (_balls.Count == characterBalls.Count)
        {
            Debug.Log("You won!");
        }
    }
}
