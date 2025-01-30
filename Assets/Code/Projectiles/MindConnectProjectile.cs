using UnityEngine;

class MindConnectProjectile : BaseProjectile
{
    private IInputConnector _startConnector;
    private bool _wasConnected = false;

    protected override void Start()
    {
        base.Start();
        _startConnector = owner.GetComponent<IInputConnector>();
        triggerCallback = TriggerCallback;
        MainCharacterSwitcher.instance.SwitchTarget(gameObject);
    }
    private void TriggerCallback(Collider2D collision)
    {
        var success = collision.TryGetComponent(out IInputConnector connector);

        if (success)
        {
            _wasConnected = true;
            MainCharacterSwitcher.instance.SwitchTarget(collision.gameObject);
        }
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if (_wasConnected) return;
        MainCharacterSwitcher.instance.SwitchTarget(owner);
    }
}
