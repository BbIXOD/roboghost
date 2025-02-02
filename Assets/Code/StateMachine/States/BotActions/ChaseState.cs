using UnityEngine;

class ChaseState : BaseState
{
    private GameObject _target;
    private IMovement _move;
    public override void Enter(GameObject owner)
    {
        base.Enter(owner);
        var finder = owner.GetComponent<SearchSuspicious>();
        _move = owner.GetComponent<IMovement>();
        var _target = finder.GetTarget();
    }

    public override void Update(GameObject owner)
    {
        base.Update(owner);
        _move.Move((_target.transform.position - owner.transform.position).normalized);
    }
}
