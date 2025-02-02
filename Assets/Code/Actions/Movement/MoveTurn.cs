using UnityEngine;

class MoveTurn : MonoBehaviour
{
    private SpriteRenderer _sr;
    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector2 direction) {
        if (Mathf.Approximately(direction.x, 0f)) return;
        _sr.flipX = direction.x < 0;
    }
}
