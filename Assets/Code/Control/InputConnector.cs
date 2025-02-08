using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

class InputConnector : MonoBehaviour, IInputConnector
{
    public UnityEvent jump;
    public UnityEvent primary;
    public UnityEvent secondary;
    public UnityEvent special;
    public UnityEvent<Vector2> move;
    public UnityEvent<Vector2> look;


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

    private void OnJump() => jump.Invoke();
    private void OnPrimary() => primary.Invoke();
    private void OnSecondary() => secondary.Invoke();
    private void OnSpecial() => special.Invoke();
    private void OnMove(Vector2 direction) => move.Invoke(direction);
    private void OnLook(Vector2 direction) => look.Invoke(direction);
}
