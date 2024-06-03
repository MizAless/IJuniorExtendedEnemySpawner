using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected IMover Mover;

    public void Init(Target target)
    {
        Mover.SetTarget(target);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Target>(out _))
            Destroy(gameObject);
    }
}
