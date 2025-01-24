using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
abstract class BaseProjectile : MonoBehaviour
{
    protected Rigidbody2D _rb;

    [SerializeField]
    protected float _speed = 10f;

    [SerializeField]
    private float _lifeTime = 60f;

    protected virtual void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.linearVelocity = transform.right * _speed;
        Destroy(gameObject, _lifeTime);
    }
}
