using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private Vector2 _offset;

    [SerializeField]
    private float _smoothTime = 0.3f;

    private Vector3 _velocity = Vector3.zero;

    private void LateUpdate() {
        var targetPosition = _target.position + (Vector3)_offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}
