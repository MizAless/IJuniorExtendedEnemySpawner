using Unity.VisualScripting;
using UnityEngine;

public class GizmosMarker : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _sphereRadius = 0.2f;

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        Gizmos.DrawSphere(transform.position, _sphereRadius);
    }
}
