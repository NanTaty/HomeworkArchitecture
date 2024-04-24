using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class MovementState : IState
{
    private const float StoppingDistance = 0.5f;
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly NPCWorker NpcWorker;
    protected readonly WorkerLocationData WorkerLocationData;
    private MovementStateConfig _config;
    private Queue<Vector3> _targets;
    private Vector3 _currentTarget;


    public MovementState(IStateSwitcher stateSwitcher, NPCWorker npcWorker, WorkerLocationData workerLocationData)
    {
        StateSwitcher = stateSwitcher;
        NpcWorker = npcWorker;
        WorkerLocationData = workerLocationData;
        _config = NpcWorker.NpcWorkerConfig.MovementStateConfig;
    }

    private float Speed => _config.MovementSpeed;
    
    public virtual void Enter() { }

    public virtual void Exit() { }

    public void Update()
    {
        Vector3 direction = _currentTarget - NpcWorker.transform.position;
        NpcWorker.transform.position += Speed * direction.normalized * Time.deltaTime;

        if (direction.magnitude <= StoppingDistance)
        {
            SwitchTarget();
        }
    }

    protected void SetMovePosition(IEnumerable<Vector3> targets)
    {
        _targets = new Queue<Vector3>(targets);
        _currentTarget = _targets.Dequeue();
    }
    
    private void SwitchTarget()
    {
        if (_targets.Count != 0)
        {
            _currentTarget = _targets.Dequeue();
        }
        else
        {
            SwitchState();
        }
    }

    protected abstract void SwitchState();

}
