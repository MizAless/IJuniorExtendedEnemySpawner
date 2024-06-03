using UnityEngine;

[RequireComponent(typeof(LinearMover))]
public class NormalEnemy : Enemy
{
    private void Awake()
    {
        Mover = GetComponent<LinearMover>();
    }
}
