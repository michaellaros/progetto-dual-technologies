using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezelevette : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public float currentTime = 0f;
    public float startingTime = 5f;
    private bool timer;
    // Start is called before the first frame update
    void Start()
    {
        left.GetComponent<Left>().movementSpeed = 0.5f;
        right.GetComponent<Right>().movementSpeed = 0.5f;
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("OnCollisionEnter",1f);
        if (timer)
        {
            currentTime -= 1 * Time.deltaTime;
        }

        if (currentTime <= 0f)
        {
            left.GetComponent<Left>().movementSpeed = 0.5f;
            right.GetComponent<Right>().movementSpeed = 0.5f;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            timer = true;
            left.GetComponent<Left>().movementSpeed = 10f;
            right.GetComponent<Right>().movementSpeed = 10f;
        }
        Destroy(gameObject);
        
    }
}
