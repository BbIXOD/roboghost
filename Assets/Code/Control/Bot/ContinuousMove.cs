using UnityEngine;
using UnityEngine.Events;

class ContinuousMove : MonoBehaviour, IInputConnector
{
    public Vector2 direction;

    [SerializeField]
    private UnityEvent<Vector2> _move;

    private void FixedUpdate()
    {
        _move.Invoke(direction);
    }

    public void Connect() => enabled = true;
    public void Disconnect() => enabled = false;
}
