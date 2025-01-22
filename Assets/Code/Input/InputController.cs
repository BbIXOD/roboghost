using UnityEngine;

public class InputController : SingletonBehaviour<InputController>
{
    public delegate void MoveAction(Vector2 direction);
    public delegate void JumpAction();
    public delegate void PrimaryAction();
    public delegate void SecondaryAction();

    public event MoveAction OnMove;
    public event JumpAction OnJump;
    public event PrimaryAction OnPrimary;
    public event SecondaryAction OnSecondary;

    private PlayerInputActions _playerInput;
    
    protected override void Awake()
    {
        _playerInput = new();
        _playerInput.Player.Jump.performed += (_) => OnJump();
        _playerInput.Player.Primary.performed += (_) => OnPrimary();
        _playerInput.Player.Secondary.performed += (_) => OnSecondary();
        base.Awake();
    }

    private void FixedUpdate()
    {
        OnMove(_playerInput.Player.Move.ReadValue<Vector2>());
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
