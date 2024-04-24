using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkMovementState : MovementState
{
    public WorkMovementState(IStateSwitcher stateSwitcher, NPCWorker npcWorker, WorkerLocationData workerLocationData) : base(stateSwitcher, npcWorker, workerLocationData)
    {
    }

    public override void Enter()
    {
        base.Enter();
        SetMovePosition(WorkerLocationData.WorkPathPos);
        Debug.Log(GetType());
    }

    protected override void SwitchState()
    {
        StateSwitcher.SwitchState<WorkState>();
    }
}
