using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Rest State Идентичен Work State по коду, но представим что у них разное поведение
public class RestState : ActionState
{
    public RestState(IStateSwitcher stateSwitcher, NPCWorker npcWorker) : base(stateSwitcher, npcWorker)
    {
    }

    private float RestStateTimer => _stateConfig.RestStateConfig.RestStateTimer;
    
    public override void Enter()
    {
        base.Enter();
        LaunchStateTimer(RestStateTimer);
    }

    protected override void StateTimer_OnTimerOver()
    {
        base.StateTimer_OnTimerOver();
        _stateSwitcher.SwitchState<WorkMovementState>();
    }
    

}
