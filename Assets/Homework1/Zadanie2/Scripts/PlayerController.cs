using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    //Тут инпут не относящийся к заданию, но буду рад вашему фидбеку :)
    public class PlayerController : MonoBehaviour, IMovable
    {
        [SerializeField] private float speed;
        public Transform Transform => transform;
        public float Speed => speed;
        public float HorizontalMovement { get; set; }
        public float VerticalMovement { get; set; }
        
        private IInput _input;

        public void SetInput(IInput input)
        {
            _input = input;
        }

        private void Update()
        {
            _input.Update();
        }
        
    }
}

