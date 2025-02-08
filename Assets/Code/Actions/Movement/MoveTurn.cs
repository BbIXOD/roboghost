using UnityEngine;

class MoveTurn : MonoBehaviour
{
    public void Move(Vector2 direction)
    {
        if (Mathf.Approximately(direction.x, 0f)) return;
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * Mathf.Sign(direction.x), transform.localScale.y, transform.localScale.z);
    }
}
