using UnityEngine;

interface ITransition {
    public IState TargetState { get; }

    public bool CanTransition(GameObject owner);
}
