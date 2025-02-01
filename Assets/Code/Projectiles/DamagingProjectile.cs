using UnityEngine;

class DamagingProjectile : BaseProjectile
{
    [SerializeField] private int _damage;

    private void TriggerAction(Collider2D other)
    {
        if (!other.TryGetComponent(out IDamageable damageable)) return;
        damageable.TakeDamage(_damage);
        Destroy(gameObject);
    }
}
