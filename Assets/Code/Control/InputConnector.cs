using UnityEngine;
using UnityEngine.Events;

class InputConnector : MonoBehaviour
{
    [SerializeField]
    private UnityAction _jump;
    [SerializeField]
    private UnityAction _primary;
    [SerializeField]
    private UnityAction _secondary;
    [SerializeField]
    private UnityAction _special;
    [SerializeField]
    private UnityAction<Vector2> _move;

    public bool isConnected = false;

    public void Connect()
    {
        isConnected = true;
        var input = InputController.instance;
        input.OnJump.AddListener(_jump);
        input.OnPrimary.AddListener(_primary);
        input.OnSecondary.AddListener(_secondary);
        input.OnSpecial.AddListener(_special);
        input.OnMove.AddListener(_move);
    }

    public void Disconnect()
    {
        isConnected = false;
        var input = InputController.instance;
        input.OnJump.RemoveListener(_jump);
        input.OnPrimary.RemoveListener(_primary);
        input.OnSecondary.RemoveListener(_secondary);
        input.OnSpecial.RemoveListener(_special);
        input.OnMove.RemoveListener(_move);
    }
}
