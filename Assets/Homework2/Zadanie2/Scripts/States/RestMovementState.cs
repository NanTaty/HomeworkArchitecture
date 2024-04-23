using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestMovementState : MovementState
{
    public RestMovementState(IStateSwitcher stateSwitcher, NPCWorker npcWorker, WorkerLocationData workerLocationData) : base(stateSwitcher, npcWorker, workerLocationData)
    {
    }

    public override void Enter()
    {
        base.Enter();
        SetMovePosition(WorkerLocationData.RestTransform);
        CalculateMove();
        Debug.Log(GetType());
    }

    protected override void SwitchState()
    {
        StateSwitcher.SwitchState<RestState>();
    }
}
