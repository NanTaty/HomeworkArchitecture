namespace Zadanie3H2
{
    using System;
    using UnityEngine;

    [Serializable]
    public class RunningStateConfig
    {
        [field: SerializeField, Range(5, 10)] public float RunSpeed { get; private set; }
        [field: SerializeField, Range(10, 20)] public float FastRunningSpeed { get; private set; }

        [field: SerializeField, Range(0, 5)] public float WalkingSpeed { get; private set; }
    }
}
