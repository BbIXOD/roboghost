using UnityEngine;

[RequireComponent(typeof(IInputConnector))]
class DisconnectMindLauncher : Launcher
{
    private IInputConnector _connector;
    private void Start()
    {
        _connector = GetComponent<IInputConnector>();
        _cooldown = new InstantCooldown();
    }
    public override bool Launch()
    {
        var wasLaunched = base.Launch();
        if (wasLaunched)
        {
            _connector.Disconnect();
            launchedProjectile.GetComponent<MindConnectProjectile>().startConnector = _connector;
        }
        return wasLaunched;
    }

    public void LaunchAndDisconnect() => Launch();
}
