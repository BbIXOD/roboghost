using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
class Walker : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Walk(Vector2 direction)
    {
        _rb.linearVelocityX = Mathf.Approximately(direction.x, 0f) ? 0f : Mathf.Sign(direction.x) * speed;
    }
}
