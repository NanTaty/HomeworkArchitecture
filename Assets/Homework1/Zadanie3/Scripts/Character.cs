using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Objective _objective;
    private BallColors _ballColor;
    private List<Ball> _balls;

    private void Awake()
    {
        _balls = new List<Ball>();
    }

    public void SetupObjective(Objective objective)
    {
        _objective = objective;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IPickable pickable))
        {
            if (_objective.AddBallColorToList(pickable, _balls))
            {
                _balls.Add(pickable.PickableBall);
            }
            _objective.CheckForWin(_balls);
        }
    }
}
