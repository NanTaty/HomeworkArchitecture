using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zadanie3H2
{
    public class FastRunningState : GroundedState
    {
        private readonly RunningStateConfig _config;

        public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(
            stateSwitcher, data, character)
        {
            _config = character.Config.RunningStateConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.FastRunningSpeed;
        }

        public override void Update()
        {
            base.Update();
            if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
            if (IsRunPressed() == false)
            {
                StateSwitcher.SwitchState<RunningState>();
            }
        }
    }
}
