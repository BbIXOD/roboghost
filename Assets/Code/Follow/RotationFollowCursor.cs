using UnityEngine;
class RotationFollowCursor : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    public void Look(Vector2 destPos)
    {
        var dir = _camera.ScreenToWorldPoint(destPos) - transform.position;
        dir.z = transform.position.z;
        transform.right = dir;
    }
}
