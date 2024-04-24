using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zadanie3H2;

public class MovingState : GroundedState
{
    protected readonly RunningStateConfig _config;
    
    public MovingState(Zadanie3H2.IStateSwitcher stateSwitcher, StateMachineData data, Zadanie3H2.Character character) : base(stateSwitcher, data, character)
    {
        _config = character.Config.RunningStateConfig;
    }

    public override void Update()
    {
        base.Update();
        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();
    }
}
