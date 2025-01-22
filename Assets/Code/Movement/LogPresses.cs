using UnityEngine;

class LogPresses : MonoBehaviour
{
    private void Awake()
    {
        var input = InputController.instance;
        input.OnJump += () => Debug.Log("Jump pressed");
        input.OnPrimary += () => Debug.Log("Primary attack button pressed");
        input.OnSecondary += () => Debug.Log("Secondary attack button pressed");
        input.OnMove += (direction) => Debug.Log($"Move in the {direction} direction");
    }
}
