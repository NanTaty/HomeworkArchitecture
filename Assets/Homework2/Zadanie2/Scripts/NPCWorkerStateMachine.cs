using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NPCWorkerStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public NPCWorkerStateMachine(NPCWorker npcWorker, WorkerLocationData workerLocationData)
    {
        _states = new List<IState>()
        {
            new RestState(this, npcWorker),
            new WorkMovementState(this, npcWorker, workerLocationData),
            new WorkState(this, npcWorker),
            new RestMovementState(this, npcWorker, workerLocationData),
        };

        _currentState = _states[0];
        _currentState.Enter();
    }
    
    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}
