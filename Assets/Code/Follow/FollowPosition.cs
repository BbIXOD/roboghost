using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [SerializeField]
    protected Transform target;
    [SerializeField]
    private Vector2 _offset;

    [SerializeField]
    private float _smoothTime = 0.3f;

    private Vector3 _velocity = Vector3.zero;

    private void LateUpdate()
    {
        var targetPosition = target.position + (Vector3)_offset;
        targetPosition.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}
