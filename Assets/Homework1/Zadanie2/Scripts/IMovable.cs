using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public interface IMovable
    {
        Transform Transform { get; }
        public float Speed { get; }
        public float HorizontalMovement { get; set; }
        public float VerticalMovement { get; set; }
    }
}

