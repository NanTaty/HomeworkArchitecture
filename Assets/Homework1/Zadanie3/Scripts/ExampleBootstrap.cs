using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ExampleBootstrap : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private List<Ball> _balls;
    private IEnumerable<Ball> _blueBalls;

    private IObjective _objective;

    private void Start()
    {
        _character.OnBallPicked += Character_OnBallPicked;
        
        _blueBalls = _balls.Where(ball => ball is BlueBall);
        
        _objective = new CollectBlueBallsObjective(_blueBalls);
    }

    private void Character_OnBallPicked()
    {
        _objective?.CheckForWin(_character.Balls);
    }
}
