using UnityEngine;
using UnityEngine.Events;

public class InputController : SingletonBehaviour<InputController>
{

    public UnityEvent<Vector2> OnMove;
    public UnityEvent OnJump;
    public UnityEvent OnPrimary;
    public UnityEvent OnSecondary;

    private PlayerInputActions _playerInput;

    protected override void Awake()
    {
        _playerInput = new();
        _playerInput.Player.Jump.performed += (_) => OnJump.Invoke();
        _playerInput.Player.Primary.performed += (_) => OnPrimary.Invoke();
        _playerInput.Player.Secondary.performed += (_) => OnSecondary.Invoke();
        base.Awake();
    }

    private void FixedUpdate()
    {
        OnMove.Invoke(_playerInput.Player.Move.ReadValue<Vector2>());
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
