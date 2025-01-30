using UnityEngine;

public class MainCharacterSwitcher : SingletonBehaviour<MainCharacterSwitcher>
{
    private GameObject _mainCharacter;
    private Rigidbody2D _rb;
    private IInputConnector _connector;
    public void SwitchTarget(GameObject target)
    {
        _connector?.Disconnect();
        if (_rb != null) _rb.interpolation = RigidbodyInterpolation2D.None;

        _mainCharacter = target;
        _connector = target.GetComponent<IInputConnector>();
        _rb = target.GetComponent<Rigidbody2D>();

        _connector?.Connect();
        EventPositionFollower.OnTargetChanged?.Invoke(_mainCharacter.transform);
        if (_rb != null) _rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }
}
