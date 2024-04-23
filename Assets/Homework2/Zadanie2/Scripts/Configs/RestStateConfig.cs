using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RestStateConfig
{
    [field: SerializeField, Range(1, 10)] public float RestStateTimer { get; private set; }
}
