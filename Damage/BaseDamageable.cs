abstract class BaseDamageable : MonoBehaviour, IDamageable
{

    [SerializeField]
    private int _maxHealth = 0;
    private int _health = _maxHealth;
    public int Health { get => _health; };
    public void TakeDamage(int damage) {
        _health -= damage;
        if (_health <= 0) {
            OnDeath();
        }
    }

    private void OnDeath() {
        Destroy(gameObject);
    }
}
