using System.Collections.Generic;
using UnityEngine;

public class SearchComponent<T> : MonoBehaviour
{
    private Collider2D _triggerCollider;
    private readonly List<T> _found = new();

    public void SetTrigger(Collider2D trigger)
    {
        _triggerCollider = trigger;
    }

    public IReadOnlyList<T> Found
    {
        get
        {
            _found.Clear();
            if (_triggerCollider == null) return _found;

            var contactFilter = new ContactFilter2D();
            var results = new List<Collider2D>();
            _triggerCollider.Overlap(contactFilter, results);

            foreach (var collider in results)
            {
                if (collider.TryGetComponent(out T component))
                {
                    _found.Add(component);
                }
            }

            return _found;
        }
    }
}
