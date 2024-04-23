using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "NPCWorkerConfig", menuName = "Configs/NPCWorker")]
public class NPCWorkerConfig : ScriptableObject
{
    [SerializeField] private RestStateConfig _restStateConfig;
    [SerializeField] private MovementStateConfig _movementStateConfig;
    [SerializeField] private WorkStateConfig _workStateConfig;

    public RestStateConfig RestStateConfig => _restStateConfig;
    public MovementStateConfig MovementStateConfig => _movementStateConfig;

    public WorkStateConfig WorkStateConfig => _workStateConfig;
}
