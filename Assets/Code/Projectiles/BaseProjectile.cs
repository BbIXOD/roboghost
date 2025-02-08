using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
abstract class BaseProjectile : MonoBehaviour
{
    [NonSerialized]
    public GameObject owner;
    protected Rigidbody2D _rb;

    [SerializeField]
    protected float _speed = 10f;

    [SerializeField]
    private float _lifeTime = 60f;

    protected Action<Collider2D> triggerCallback = (collision) => { };

    protected virtual void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = transform.right * _speed;
        Destroy(gameObject, _lifeTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.root.gameObject == owner) return;

        triggerCallback(collision);
    }
}
