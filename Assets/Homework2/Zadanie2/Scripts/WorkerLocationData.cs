using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerLocationData
{
    private IEnumerable<Vector3> _workPathPos;
    private IEnumerable<Vector3> _restPathPos;

    public WorkerLocationData(IEnumerable<Vector3> workPathPos, IEnumerable<Vector3> restPathPos)
    {
        _workPathPos = workPathPos;
        _restPathPos = restPathPos;
    }

    public IEnumerable<Vector3> WorkPathPos => _workPathPos;
    public IEnumerable<Vector3> RestPathPos => _restPathPos;
}
