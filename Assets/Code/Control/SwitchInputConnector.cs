using System;
using System.Linq;
using UnityEngine;

class SwitchInputConnector : MonoBehaviour, IInputConnector
{
    public MonoBehaviour[] defaultConnections;
    public MonoBehaviour[] secondaryConnections;

    private IInputConnector[] _defaultConnections;
    private IInputConnector[] _secondaryConnections;


    private void Awake()
    {
        if (defaultConnections.Any(c => c as IInputConnector == null)
            || secondaryConnections.Any(c => c as IInputConnector == null))
        {
            throw new Exception("All connections must implement IInputConnector");
        }

        _defaultConnections = defaultConnections.Select(c => c as IInputConnector).ToArray();
        _secondaryConnections = secondaryConnections.Select(c => c as IInputConnector).ToArray();
    }

    public void Connect() => UpdateConnections(true);

    public virtual void Disconnect() => UpdateConnections(false);

    private void UpdateConnections(bool isConnected)
    {
        Array.ForEach(isConnected ? _secondaryConnections : _defaultConnections, c => c.Connect());
        Array.ForEach(isConnected ? _defaultConnections : _secondaryConnections, c => c.Disconnect());
    }
}
