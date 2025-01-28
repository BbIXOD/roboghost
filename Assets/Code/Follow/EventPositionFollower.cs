using System;
using UnityEngine;

class EventPositionFollower : FollowPosition
{
    public static Action<Transform> OnTargetChanged;
    public void SetTarget(Transform target) => base.target = target;

    private void Awake()
    {
        OnTargetChanged += SetTarget;
    }
}
