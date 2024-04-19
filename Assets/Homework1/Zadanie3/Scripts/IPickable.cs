using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickable
{
    BallColors BallColor { get; }
    Ball PickableBall { get; }
    void Pick();
}
