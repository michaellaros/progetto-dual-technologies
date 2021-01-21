using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lleftcontroller : MonoBehaviour
{
    readonly float minAngle = 46.86f;
    readonly float maxAngle = -23.15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {
            float angle = Mathf.LerpAngle(minAngle, maxAngle,0.5f * Time.time);
            transform.eulerAngles = new Vector3(0, angle, 0);
        }

        if (!Input.GetMouseButtonDown(0))

        {
            float angle = Mathf.LerpAngle(maxAngle, minAngle,0.5f * Time.time);
            transform.eulerAngles = new Vector3(0, angle, 0);
        }
    }
}
