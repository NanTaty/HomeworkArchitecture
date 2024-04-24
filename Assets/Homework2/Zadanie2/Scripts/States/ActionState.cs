using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionState : IState
{
    protected readonly IStateSwitcher _stateSwitcher;
    protected readonly NPCWorkerConfig _stateConfig;
    private Timer _stateTimer;

    public ActionState(IStateSwitcher stateSwitcher, NPCWorker npcWorker)
    {
        _stateSwitcher = stateSwitcher;
        _stateConfig = npcWorker.NpcWorkerConfig;
    }
    
    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public void Exit()
    {
        _stateTimer.OnTimerOver -= StateTimer_OnTimerOver;
    }

    public virtual void Update()
    {
        _stateTimer?.TimerUpdate();
    }

    protected void LaunchStateTimer(float timer)
    {
        _stateTimer = new Timer(timer);
        _stateTimer.OnTimerOver += StateTimer_OnTimerOver;
    }

    protected virtual void StateTimer_OnTimerOver()
    {
    }
}
