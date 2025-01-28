class NoCooldownLauncher : Launcher
{
    private void Start() {
        _cooldown = new InstantCooldown();
    }
}
