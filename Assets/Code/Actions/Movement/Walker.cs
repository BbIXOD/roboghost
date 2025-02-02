using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
class Walker : MonoBehaviour, IMovement
{
    public float speed = 1f;
    public float acceleration = 1f;
    private float _velocityX;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Walk(Vector2 direction)
    {
        var _destSpeed = Mathf.Approximately(direction.x, 0f) ? 0f : Mathf.Sign(direction.x) * speed;
        _velocityX = Mathf.MoveTowards(_velocityX, _destSpeed, acceleration * Time.fixedDeltaTime);
        _rb.linearVelocityX = _velocityX;
    }

    public void Move(Vector2 direction) => Walk(direction);
}
