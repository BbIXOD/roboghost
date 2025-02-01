using System.Collections.Generic;
using UnityEngine;

interface IState {
    public void Enter(GameObject owner);
    public void Exit(GameObject owner);

    public void Update(GameObject owner);

    public List<ITransition> Transitions { get; }
}
