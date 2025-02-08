using UnityEngine;

class InputToPlayer : MonoBehaviour {
    public void Connect() {
        MainCharacterSwitcher.instance.SwitchTarget(PlayerInstance.instance.Player);
    }
}
