using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class MovementStateConfig
{
    [field: SerializeField, Range(1, 10)] public float MovementSpeed { get; private set; }
}
