using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerLocationData
{
    private Transform _workTransform;
    private Transform _restTransform;

    public WorkerLocationData(Transform workTransform, Transform restTransform)
    {
        _workTransform = workTransform;
        _restTransform = restTransform;
    }

    public Transform WorkTransform => _workTransform;
    public Transform RestTransform => _restTransform;
}
