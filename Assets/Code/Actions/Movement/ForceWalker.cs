using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
class ForceWalker : MonoBehaviour
{
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    public float force = 1f;
    public float maxSpeed = 10f;

    public void Walk(Vector2 direction)
    {
        if (!Mathf.Approximately(direction.x, 0f))
        {
            var _destDirection = Mathf.Sign(direction.x);
            var _destSpeed = _destDirection * force * Time.fixedDeltaTime;
            _rb.AccelerateX(_destSpeed, maxSpeed);
        }
        else
        {
            var currentSpeed = _rb.linearVelocityX;
            var deceleration = Mathf.Min(Mathf.Abs(currentSpeed) * _rb.mass, force * Time.fixedDeltaTime);
            var decDirection = -Mathf.Sign(currentSpeed);

            _rb.AccelerateX(deceleration * decDirection, maxSpeed);
        }
    }

}
