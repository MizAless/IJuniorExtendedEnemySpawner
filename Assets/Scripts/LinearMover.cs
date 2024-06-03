using UnityEngine;

public class LinearMover : MonoBehaviour, IMover
{
    [SerializeField] private float _speed;
    
    private Target _target;

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
        Vector3 direction = _target.Position - transform.position;
        transform.position += direction.normalized * _speed * Time.fixedDeltaTime;
    }
}
