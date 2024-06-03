using UnityEngine;

[RequireComponent(typeof(CycleMover))]
public class Target : MonoBehaviour
{
    public Vector3 Position => transform.position;
}
