using UnityEngine;

abstract class BaseDamageable : MonoBehaviour, IDamageable
{

    [SerializeField]
    private int _maxHealth = 0;

    public int Health { get; private set; }
    private void Start()
    {
        Health = _maxHealth;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            OnDeath();
        }
    }

    private void OnDeath()
    {
        Destroy(gameObject);
    }
}
