using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie3H2
{
    public class FastRunningState : MovingState
    {
        public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(
            stateSwitcher, data, character)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.FastRunningSpeed;
        }

        public override void Update()
        {
            base.Update();
            if (IsRunPressed() == false)
            {
                StateSwitcher.SwitchState<RunningState>();
            }
        }
    }
}
