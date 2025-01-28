using UnityEngine;

class Launcher : MonoBehaviour
{
    [SerializeField]
    protected GameObject projectile;

    protected GameObject launchedProjectile;
    [SerializeField]
    protected GameObject owner;

    public ICooldown _cooldown;
    public virtual bool Launch()
    {
        if (!_cooldown.IsReady) return false;

        launchedProjectile = Instantiate(projectile, transform.position, transform.rotation);
        launchedProjectile.GetComponent<BaseProjectile>().owner = owner != null ? owner : transform.root.gameObject;
        _cooldown.StartCooldown();
        return true;
    }

    public void LaunchProjectile() => Launch();

}
