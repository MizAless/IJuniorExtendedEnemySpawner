using UnityEngine;

public class ParabolicMover : MonoBehaviour, IMover
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxAngleOffset;
    [SerializeField] private float _angleChangeSpeed;

    private Target _target;

    private float _parabolicAngle = 0;
    private int _offsetDirection = 1;

    private void FixedUpdate()
    {
        Move();
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        ChangeParabolicAngle();
        Vector3 direction = _target.Position - transform.position;
        Vector3 rotatedDirection = Quaternion.Euler(0, _parabolicAngle, 0) * direction;
        transform.position += rotatedDirection.normalized * _speed * Time.fixedDeltaTime;
    }

    private void ChangeParabolicAngle()
    {
        if (Mathf.Abs(_parabolicAngle) > _maxAngleOffset)
            _offsetDirection *= -1;

        _parabolicAngle += _angleChangeSpeed * Time.fixedDeltaTime * _offsetDirection;
    }
}
