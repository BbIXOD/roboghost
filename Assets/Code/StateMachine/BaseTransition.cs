using UnityEngine;

abstract class BaseTransition : ITransition
{
    public IState TargetState { get; }
    public BaseTransition(IState targetState)
    {
        TargetState = targetState;
    }

    public abstract bool CanTransition(GameObject owner);
}
