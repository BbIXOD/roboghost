using UnityEngine;
using UnityEngine.Events;

public class InputController : SingletonBehaviour<InputController>
{

    public UnityEvent<Vector2> OnMove;
    public UnityEvent OnJump;
    public UnityEvent OnPrimary;
    public UnityEvent OnSecondary;
    public UnityEvent OnSpecial;
    public UnityEvent<Vector2> OnLook;

    private PlayerInputActions _playerInput;

    protected override void Awake()
    {
        _playerInput = new();
        _playerInput.Player.Jump.performed += (_) => OnJump.Invoke();
        _playerInput.Player.Primary.performed += (_) => OnPrimary.Invoke();
        _playerInput.Player.Secondary.performed += (_) => OnSecondary.Invoke();
        _playerInput.Player.Special.performed += (_) => OnSpecial.Invoke();
        base.Awake();
    }

    private void FixedUpdate()
    {
        OnMove?.Invoke(_playerInput.Player.Move.ReadValue<Vector2>());
        OnLook?.Invoke(_playerInput.Player.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }
}
