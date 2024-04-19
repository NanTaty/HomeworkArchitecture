using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBallPicker
{
    List<Ball> Balls { get; }
    void PickBall(Ball ball);
}
