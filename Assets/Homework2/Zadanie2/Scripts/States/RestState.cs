using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Rest State Идентичен Work State по коду, но представим что у них разное поведение
public class RestState : IState
{
    private readonly IStateSwitcher _stateSwitcher;
    private RestStateConfig _stateConfig;
    private float _stateTimer;

    public RestState(IStateSwitcher stateSwitcher, NPCWorker npcWorker)
    {
        _stateSwitcher = stateSwitcher;
        _stateConfig = npcWorker.NpcWorkerConfig.RestStateConfig;
    }
    
    public void Enter()
    {
        _stateTimer = _stateConfig.RestStateTimer;
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
            _stateSwitcher.SwitchState<WorkMovementState>();
        }
    }

}
