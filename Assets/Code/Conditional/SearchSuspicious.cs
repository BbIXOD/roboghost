using System.Collections.Generic;
using UnityEngine;

class SearchSuspicious : SearchComponent<Suspicious>
{
    [SerializeField]
    private Transform[] _rayCastPoints;
    private GameObject _target;
    private bool _wasUpdated;

    private void FixedUpdate() {
        _wasUpdated = false;
    }

    public GameObject GetTarget() {
        if (_wasUpdated) return _target;
        _wasUpdated = true;

        foreach (var component in Found) {
            foreach (var point in _rayCastPoints) {
                var ray = new Ray(point.position, point.up);
                var hit = Physics2D.Raycast(ray.origin, ray.direction);
                if (hit.collider != null && hit.collider.gameObject == component.gameObject) {
                    _target = component.gameObject;
                    return _target;
                }
            }
        }

        return null;
    }

}
