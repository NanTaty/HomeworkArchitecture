using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExampleBootstrap : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private List<Ball> _balls;
    private Objective _objective;

    private void Awake()
    {
        _objective = new PickSameColorObjective(_balls);
        _character.SetupObjective(_objective);
    }
}
