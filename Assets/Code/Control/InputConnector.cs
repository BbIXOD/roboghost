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
    private UnityAction<Vector2> _move;

    public void Connect()
    {
        var input = InputController.instance;
        input.OnJump.AddListener(_jump);
        input.OnPrimary.AddListener(_primary);
        input.OnSecondary.AddListener(_secondary);
        input.OnMove.AddListener(_move);
    }
}
