using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pressedRotationpoint;
    Vector3 originalRotation;
    public float movementSpeed;

    void Start()
    {
        originalRotation = transform.eulerAngles;
        InputManager.Singleton.RDownEvent.AddListener(RDown);
        InputManager.Singleton.RUpEvent.AddListener(RUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RDown()
    {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", pressedRotationpoint.eulerAngles, "easeType", "easeOutQuint", "time", movementSpeed)); 
    }

    public void RUp()
    {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", originalRotation, "easeType", "easeOutQuint", "time", movementSpeed));
    }
}
