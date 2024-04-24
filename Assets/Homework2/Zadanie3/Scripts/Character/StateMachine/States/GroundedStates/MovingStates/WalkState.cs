namespace Zadanie3H2
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class WalkState : MovingState
    {
        public WalkState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher,
            data, character)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Data.Speed = _config.WalkingSpeed;
        }

        public override void Update()
        {
            base.Update();
            if (IsWalkPressed() == false)
            {
                StateSwitcher.SwitchState<RunningState>();
            }
        }
    }
}
