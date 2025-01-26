using UnityEngine;

static class RigidbodyExtensions
{
    public static void AccelerateX(this Rigidbody2D rb, float acceleration, float maxSpeed)
    {
        rb.AddForce(Vector2.right * acceleration, ForceMode2D.Impulse);
        rb.linearVelocityX = Mathf.Clamp(rb.linearVelocityX, -maxSpeed, maxSpeed);
    }
}
