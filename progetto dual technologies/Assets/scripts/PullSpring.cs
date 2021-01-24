using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSpring : MonoBehaviour
{
    public string InputButtonName;
    public float distance = 50f;
    public float speed = 1;
    public GameObject ball;
    public float power = 2000;

    private bool ready = false;
    private bool fire = false;
    private float moveCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            ready = true;
        }
    }

    // Update is called once per frame
   
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
            }
        }

        else if(moveCount > 0)
        {
            if(fire && ready)
            {
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;

        }
        if(moveCount <=0)
        {
            fire = false;
            moveCount = 0;
        }
    }
}
