using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class WorkStateConfig
{
    [field: SerializeField, Range(1, 10)] public float WorkStateTimer { get; private set; }
}
