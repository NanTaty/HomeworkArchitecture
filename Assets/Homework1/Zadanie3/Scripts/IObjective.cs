using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjective
{
    void CheckForWin(List<Ball> balls);
}
