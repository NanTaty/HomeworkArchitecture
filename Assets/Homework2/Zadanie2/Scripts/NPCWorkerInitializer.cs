using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NPCWorkerInitializer : MonoBehaviour
{
    [SerializeField] private List<Transform> workPathPos;
    [SerializeField] private List<Transform> restPathPos;
    [SerializeField] private NPCWorker _npcWorker;
    
    private WorkerLocationData _workerLocationData;

    private void Awake()
    {
        _workerLocationData = new WorkerLocationData(workPathPos.Select(point => point.position), 
            restPathPos.Select(point => point.position));
        _npcWorker.SetStateMachine(new NPCWorkerStateMachine(_npcWorker, _workerLocationData));
    }
}
