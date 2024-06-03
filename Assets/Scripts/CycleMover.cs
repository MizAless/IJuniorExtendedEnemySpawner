using System.Collections.Generic;
using UnityEngine;

public class CycleMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private List<Transform> _movePoints;
    [SerializeField] private float _convergenceError;

    private int _currentMovePointIndex = 0;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _movePoints[_currentMovePointIndex].position, _speed * Time.fixedDeltaTime);

        TrySetNextMovePoint();
    }

    private void TrySetNextMovePoint()
    {
        Vector3 from = transform.position;
        from.y = 0;

        Vector3 to = _movePoints[_currentMovePointIndex].position;
        to.y = 0;

        if (Vector3.Distance(from, to) < _convergenceError)
        {
            _currentMovePointIndex++;
            _currentMovePointIndex %= _movePoints.Count;
        }
    }
}
