using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pressedRotationpoint;
    Vector3 originalRotation;
    public float movementSpeed;

    void Start()
    {
        originalRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", pressedRotationpoint.eulerAngles, "easeType", "easeOutQuint", "time", movementSpeed)); 
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", originalRotation, "easeType", "easeOutQuint", "time", movementSpeed));
        }
    }
}
