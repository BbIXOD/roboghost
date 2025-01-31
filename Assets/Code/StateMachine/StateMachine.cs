using UnityEngine;

class StateMachine : MonoBehaviour {

    public IState CurrentState { get; private set; }

    public void ChangeState(IState newState) {
        CurrentState?.Exit(this);
        CurrentState = newState;
        CurrentState?.Enter(this);
    }

    private void Update() => CurrentState?.Update(this);
    private void OnTriggerEnter2D(Collider2D collision) => CurrentState?.OnTriggerEnter2D(this, collision);
    private void OnTriggerExit2D(Collider2D collision) => CurrentState?.OnTriggerExit2D(this, collision);
}
