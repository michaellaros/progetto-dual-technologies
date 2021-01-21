using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot : MonoBehaviour
{
    public float gizmoSize = .75f;
    public Color gizmocolor = Color.yellow;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmocolor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
