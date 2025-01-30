using UnityEngine;

class PlayerInstance : SingletonBehaviour<PlayerInstance>
{
    [SerializeField]
    private GameObject _player;
    public static GameObject player;

    protected override void Awake()
    {
        base.Awake();
        player = _player;
    }
}
