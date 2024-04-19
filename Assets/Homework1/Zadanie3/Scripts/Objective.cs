using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Objective
{
    protected List<Ball> _balls;
    

    public abstract bool AddBallColorToList(IPickable pickable, List<Ball> characterBalls);

    public abstract void CheckForWin(List<Ball> characterBalls);
}
