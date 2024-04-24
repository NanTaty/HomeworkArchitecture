namespace Zadanie3H2
{
    public class RunningState : MovingState
    {
        public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(
            stateSwitcher, data, character)
        {}

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
            
            if (IsRunPressed())
                StateSwitcher.SwitchState<FastRunningState>();
            if (IsWalkPressed())
                StateSwitcher.SwitchState<WalkState>();
        }

    }
}
