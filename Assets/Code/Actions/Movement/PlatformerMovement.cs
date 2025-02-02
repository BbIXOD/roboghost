using UnityEngine;

class PlatformerMovement : MonoBehaviour, IMovement
{
    public float force = 10f;
    public float maxSpeed = 10f;
    public float jumpForce = 10f;

    public Collider2D[] jumpColliders;

    private ForceWalker _forceWalker;
    private MoveTurn _moveTurn;
    private Jumper _jumper;
    private void Awake() {
        _forceWalker = gameObject.AddComponent<ForceWalker>();
        _moveTurn = gameObject.AddComponent<MoveTurn>();
        _jumper = gameObject.AddComponent<Jumper>();

        _forceWalker.force = force;
        _forceWalker.maxSpeed = maxSpeed;
        _jumper.jumpForce = jumpForce;
        _jumper.colliders = jumpColliders;
    }

    public void Move(Vector2 direction) {
        _forceWalker.Move(direction);
        _moveTurn.Move(direction);
    }

    public void Jump() => _jumper.Jump();
}
