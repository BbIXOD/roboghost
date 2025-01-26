interface ICooldown
{
    bool IsReady { get; }
    void StartCooldown();
}
