using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
class Jumper : MonoBehaviour
{
    public float jumpForce = 1f;

    public Collider2D[] colliders;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (colliders.All(c => !c.IsTouchingLayers()))
        {
            return;
        }
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
