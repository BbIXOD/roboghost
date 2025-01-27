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
        var mousePos = (Vector3)destPos;
        mousePos.z = _camera.transform.position.x - transform.position.x;
        transform.LookAt(_camera.ScreenToWorldPoint(mousePos));
    }
}
