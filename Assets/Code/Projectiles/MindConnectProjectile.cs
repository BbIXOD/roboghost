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
        _startConnector.Disconnect();
        EventPositionFollower.OnTargetChanged?.Invoke(transform);
    }
    private void TriggerCallback(Collider2D collision)
    {
        var success = collision.TryGetComponent(out IInputConnector connector);

        if (success)
        {
            connector.Connect();
            EventPositionFollower.OnTargetChanged?.Invoke(collision.transform);
            _wasConnected = true;
        }
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if (_wasConnected) return;
        _startConnector.Connect();
        EventPositionFollower.OnTargetChanged?.Invoke(owner.transform);
    }
}
