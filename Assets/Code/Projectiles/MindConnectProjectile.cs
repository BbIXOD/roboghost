using UnityEngine;

class MindConnectProjectile : BaseProjectile {
    public InputConnector startConnector;
    private bool wasConnected = false;
    private void OnTriggerEnter2D(Collider2D collision) {
        var success = collision.TryGetComponent(out InputConnector connector);

        if (success) {
            connector.Connect();
            wasConnected = true;
        }
        Destroy(gameObject);
    }

    private void OnDestroy() {
        if (!wasConnected) return;
        startConnector.Connect();
    }
}
