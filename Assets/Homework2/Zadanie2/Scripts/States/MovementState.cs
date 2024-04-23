using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementState : IState
{
    private const float StoppingDistance = 0.5f;
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly NPCWorker NpcWorker;
    protected readonly WorkerLocationData WorkerLocationData;
    private Vector3 _movementPos;
    private Vector3 _moveDirection;
    private MovementStateConfig _config;
    

    public MovementState(IStateSwitcher stateSwitcher, NPCWorker npcWorker, WorkerLocationData workerLocationData)
    {
        StateSwitcher = stateSwitcher;
        NpcWorker = npcWorker;
        WorkerLocationData = workerLocationData;
        _config = NpcWorker.NpcWorkerConfig.MovementStateConfig;
    }

    private float Speed => _config.MovementSpeed;
    
    public virtual void Enter()
    {
        
    }

    public virtual void Exit()
    {
        
    }

    public void Update()
    {
        NpcWorker.transform.position += Speed * _moveDirection * Time.deltaTime;
        if (Vector3.Distance(NpcWorker.transform.position, _movementPos) <= StoppingDistance)
        {
            SwitchState();
        }
    }

    protected void SetMovePosition(Transform position)
    {
        _movementPos = position.position;
    }

    protected void CalculateMove()
    {
        _moveDirection = (_movementPos - NpcWorker.transform.position).normalized;
    }

    protected abstract void SwitchState();

}
