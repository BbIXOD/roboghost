using UnityEngine;

class MindConnectProjectile : BaseProjectile
{
    public IInputConnector startConnector;
    private bool _wasConnected = false;

    protected override void Start()
    {
        base.Start();
        triggerCallback = TriggerCallback;
    }
    private void TriggerCallback(Collider2D collision)
    {
        var success = collision.TryGetComponent(out IInputConnector connector);

        if (success)
        {
            connector.Connect();
            _wasConnected = true;
        }
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if (_wasConnected) return;
        startConnector.Connect();
    }
}
