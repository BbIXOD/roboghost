using UnityEngine;

class PlayerInstance : SingletonBehaviour<PlayerInstance>
{
    public GameObject Player { get; private set; }
    public void SetPlayer(GameObject player)
    {
        if (Player != null) {
            throw new System.Exception("Player already set");
        }
        Player = player;
    }

}
