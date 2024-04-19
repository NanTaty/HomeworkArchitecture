using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickable
{
    BallColors BallColor { get; }
    Ball ThisBall { get; }
    void Pick();
}
