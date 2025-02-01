using System.Collections.Generic;
using UnityEngine;

class BaseState : IState
{
    public List<ITransition> Transitions => new();

    public void Enter(GameObject owner) {}
    public void Exit(GameObject owner) {}
    public void Update(GameObject owner) {}
}
