using UnityEngine;

class BaseState : IState
{
    public void Enter(StateMachine machine) {}
    public void Exit(StateMachine machine) {}
    public void OnTriggerEnter2D(StateMachine machine, Collider2D other) {}
    public void OnTriggerExit2D(StateMachine machine, Collider2D other) {}
    public void Update(StateMachine machine) {}
}
