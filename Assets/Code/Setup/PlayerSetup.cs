using UnityEngine;

class PlayerSetup : MonoBehaviour {
    private void Start() {
        PlayerInstance.instance.SetPlayer(gameObject);
        MainCharacterSwitcher.instance.SwitchTarget(gameObject);
    }
}
