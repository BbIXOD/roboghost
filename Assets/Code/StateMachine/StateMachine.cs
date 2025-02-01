using UnityEngine;

class StateMachine : MonoBehaviour
{

    public IState CurrentState { get; private set; }

    public void ChangeState(IState newState)
    {
        CurrentState?.Exit(gameObject);
        CurrentState = newState;
        CurrentState?.Enter(gameObject);
    }

    private void Update()
    {
        CurrentState?.Update(gameObject);

        foreach (var transition in CurrentState.Transitions)
        {
            if (transition.CanTransition(gameObject))
            {
                ChangeState(transition.TargetState);
                break;
            }
        }
    }
}

