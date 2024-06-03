using UnityEngine;

[RequireComponent (typeof(ParabolicMover))]
public class DrunkEnemy : Enemy
{
    private void Awake()
    {
        Mover = GetComponent<ParabolicMover>();
    }
}
