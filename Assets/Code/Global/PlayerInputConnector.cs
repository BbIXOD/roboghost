using UnityEngine;

class PlayerInputConnector : SingletonBehaviour<PlayerInputConnector>
{
    [SerializeField]
    private InputConnector _input;
    public static InputConnector input;

    protected override void Awake()
    {
        base.Awake();
        input = _input;
    }
}
