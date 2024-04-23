using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWorker : MonoBehaviour
{
    [SerializeField] private NPCWorkerConfig _config;

    private NPCWorkerStateMachine _npcWorkerStateMachine;
    public NPCWorkerConfig NpcWorkerConfig => _config;

    private void Update()
    {
        _npcWorkerStateMachine?.Update();
    }

    public void SetStateMachine(NPCWorkerStateMachine npcWorkerStateMachine)
    {
        _npcWorkerStateMachine = npcWorkerStateMachine;
    }
}
