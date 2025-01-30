using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

class InputConnector : MonoBehaviour, IInputConnector
{
    [SerializeField]
    private UnityEvent _jump;
    [SerializeField]
    private UnityEvent _primary;
    [SerializeField]
    private UnityEvent _secondary;
    [SerializeField]
    private UnityEvent _special;
    [SerializeField]
    private UnityEvent<Vector2> _move;
    [SerializeField]
    private UnityEvent<Vector2> _look;


    public void Connect()
    {
        var input = InputController.instance;
        input.OnJump.Subscribe(OnJump);
        input.OnPrimary.Subscribe(OnPrimary);
        input.OnSecondary.Subscribe(OnSecondary);
        input.OnSpecial.Subscribe(OnSpecial);
        input.OnMove.Subscribe(OnMove);
        input.OnLook.Subscribe(OnLook);
        Debug.Log($"Input connected to {gameObject.name}");
    }

    public void Disconnect()
    {
        var input = InputController.instance;
        input.OnJump.Unsubscribe(OnJump);
        input.OnPrimary.Unsubscribe(OnPrimary);
        input.OnSecondary.Unsubscribe(OnSecondary);
        input.OnSpecial.Unsubscribe(OnSpecial);
        input.OnMove.Unsubscribe(OnMove);
        input.OnLook.Unsubscribe(OnLook);
        Debug.Log($"Input disconnected from {gameObject.name}");
    }

    private void OnJump() => _jump.Invoke();
    private void OnPrimary() => _primary.Invoke();
    private void OnSecondary() => _secondary.Invoke();
    private void OnSpecial() => _special.Invoke();
    private void OnMove(Vector2 direction) => _move.Invoke(direction);
    private void OnLook(Vector2 direction) => _look.Invoke(direction);
}
