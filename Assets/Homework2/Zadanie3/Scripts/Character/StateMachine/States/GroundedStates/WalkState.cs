namespace Zadanie3H2
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WalkState : GroundedState
    {
        private RunningStateConfig _config;

        public WalkState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher,
            data, character)
        {
            _config = character.Config.RunningStateConfig;
        }

        public override void Enter()
        {
            base.Enter();
            Data.Speed = _config.WalkingSpeed;
        }

        public override void Update()
        {
            base.Update();
            if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
            if (IsWalkPressed() == false)
            {
                StateSwitcher.SwitchState<RunningState>();
            }
        }
    }
}
