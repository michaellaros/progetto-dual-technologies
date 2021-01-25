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
        InputManager.Singleton.LDownEvent.AddListener(LDown);
        InputManager.Singleton.LUpEvent.AddListener(LUp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LDown()
    {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", pressedRotationpoint.eulerAngles, "easeType", "easeOutQuint", "time", movementSpeed)); 
    }

    public void LUp()
    {
            iTween.RotateTo(gameObject, iTween.Hash("rotation", originalRotation, "easeType", "easeOutQuint", "time", movementSpeed));
    }
}
