namespace Zadanie3H2
{
    public interface IState
    {
        void Enter();
        void Exit();
        void HandleInput();
        void Update();
    }
}
