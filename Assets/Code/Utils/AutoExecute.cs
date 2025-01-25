using UnityEngine;
using UnityEngine.Events;

class AutoExecute : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _action;

    private void Start()
    {
        _action.Invoke();
    }
}
