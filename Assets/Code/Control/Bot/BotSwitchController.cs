using System.Diagnostics;

class BotSwitchController : SwitchInputConnector
{
    public override void Disconnect() {
        base.Disconnect();
        Debug.Print($"Bot input disconnected, connected to {PlayerInputConnector.input.gameObject.name}");
        PlayerInputConnector.input.Connect();
    }
}
