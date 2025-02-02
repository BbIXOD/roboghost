using UnityEngine;

class EnemyVisible : BaseTransition {
    private readonly bool _isVisible;
    public EnemyVisible(IState targetState, bool isVisible) : base(targetState) {
        _isVisible = isVisible;
    }

    public override bool CanTransition(GameObject gameObject) {
        var finder = gameObject.GetComponent<SearchSuspicious>();
        var target = finder.GetTarget();
        return target != null == _isVisible;
    }
}
