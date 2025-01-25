using UnityEngine.Events;

static class UnityEventExtensions
{
    public static void Subscribe<T>(this UnityEvent<T> unityEvent, UnityAction<T> action)
    {
        if (action == null) return;
        unityEvent.AddListener(action);
    }

    public static void Subscribe(this UnityEvent unityEvent, UnityAction action)
    {
        if (action == null) return;
        unityEvent.AddListener(action);
    }

    public static void Unsubscribe<T>(this UnityEvent<T> unityEvent, UnityAction<T> action)
    {
        if (action == null) return;
        unityEvent.RemoveListener(action);
    }

    public static void Unsubscribe(this UnityEvent unityEvent, UnityAction action)
    {
        if (action == null) return;
        unityEvent.RemoveListener(action);
    }
}
