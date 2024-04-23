namespace Zadanie3H2
{
    public class RunningState : GroundedState
    {
        private readonly RunningStateConfig _config;

        public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(
            stateSwitcher, data, character)
            => _config = character.Config.RunningStateConfig;

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.RunSpeed;

            View.StartRunning();
        }

        public override void Exit()
        {
            base.Exit();

            View.StopRunning();
        }

        public override void Update()
        {
            base.Update();

            if (IsHorizontalInputZero())
                StateSwitcher.SwitchState<IdlingState>();
            if (IsRunPressed())
                StateSwitcher.SwitchState<FastRunningState>();
            if (IsWalkPressed())
                StateSwitcher.SwitchState<WalkState>();
        }

    }
}
