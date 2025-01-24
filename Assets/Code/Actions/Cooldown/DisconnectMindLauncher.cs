using UnityEngine;

[RequireComponent(typeof(InputConnector))]
class DisconnectMindLauncher : Launcher
{
    private InputConnector _connector;
    private void Start()
    {
        _connector = GetComponent<InputConnector>();
    }
    public override bool Launch()
    {
        var wasLaunched = base.Launch();
        if (wasLaunched)
        {
            _connector.Disconnect();
        }
        return wasLaunched;
    }
}
