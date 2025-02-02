using System.Collections.Generic;
using UnityEngine;

class BaseState : IState
{
    public List<ITransition> Transitions => new();

    public virtual void Enter(GameObject owner) { }
    public virtual void Exit(GameObject owner) { }
    public virtual void Update(GameObject owner) { }
}
