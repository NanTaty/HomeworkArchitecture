using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : ActionState
{
    public WorkState(IStateSwitcher stateSwitcher, NPCWorker npcWorker) : base(stateSwitcher, npcWorker)
    {
    }

    private float RestStateTimer => _stateConfig.WorkStateConfig.WorkStateTimer;
    
    public override void Enter()
    {
        base.Enter();
        LaunchStateTimer(RestStateTimer);
    }

    protected override void StateTimer_OnTimerOver()
    {
        base.StateTimer_OnTimerOver();
        _stateSwitcher.SwitchState<RestMovementState>();
    }
}
