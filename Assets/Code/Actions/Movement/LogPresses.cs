using UnityEngine;

class LogPresses : MonoBehaviour
{
    private void Awake()
    {
        var input = InputController.instance;
        input.OnJump.AddListener(() => Debug.Log("Jump pressed"));
        input.OnPrimary.AddListener(() => Debug.Log("Primary attack button pressed"));
        input.OnSecondary.AddListener(() => Debug.Log("Secondary attack button pressed"));
        input.OnMove.AddListener((direction) => Debug.Log($"Move in the {direction} direction"));
    }
}
