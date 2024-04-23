using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : IState
{
    private readonly IStateSwitcher _stateSwitcher;
    private WorkStateConfig _stateConfig;
    private float _stateTimer;

    public WorkState(IStateSwitcher stateSwitcher, NPCWorker npcWorker)
    {
        _stateSwitcher = stateSwitcher;
        _stateConfig = npcWorker.NpcWorkerConfig.WorkStateConfig;
    }

    public void Enter()
    {
        _stateTimer = _stateConfig.WorkStateTimer;
        Debug.Log(GetType());
    }

    public void Exit()
    {
        
    }

    public void Update()
    {
        _stateTimer -= Time.deltaTime;
        if (_stateTimer <= 0)
        {
            _stateSwitcher.SwitchState<RestMovementState>();
        }
    }
}
