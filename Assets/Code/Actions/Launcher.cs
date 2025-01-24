using UnityEngine;

class Launcher : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;

    public ICooldown _cooldown;
    public virtual bool Launch() {
        if (!_cooldown.IsReady) return false;

        Instantiate(projectile, transform.position, transform.rotation);
        _cooldown.StartCooldown();
        return true;
    }

}
