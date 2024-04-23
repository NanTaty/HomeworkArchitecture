using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWorkerInitializer : MonoBehaviour
{
    [SerializeField] private Transform workTransform;
    [SerializeField] private Transform restTransform;
    [SerializeField] private NPCWorker _npcWorker;
    private WorkerLocationData _workerLocationData;

    private void Awake()
    {
        _workerLocationData = new WorkerLocationData(workTransform, restTransform);
        _npcWorker.SetStateMachine(new NPCWorkerStateMachine(_npcWorker, _workerLocationData));
    }
}
