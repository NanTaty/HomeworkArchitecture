using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie2
{
    public class DesktopInput : IInput
    {
        private IMovable _movable;

        public DesktopInput(IMovable movable)
        {
            _movable = movable;
        }
        
        public void Update()
        {
            _movable.HorizontalMovement = Input.GetAxisRaw("Horizontal");
            _movable.VerticalMovement = Input.GetAxisRaw("Vertical");
            Vector3 movement = new Vector3(_movable.HorizontalMovement, 0, _movable.VerticalMovement);
            
            _movable.Transform.position += movement * _movable.Speed * Time.deltaTime;
        }
    }
}

