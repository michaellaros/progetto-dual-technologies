using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSpring : MonoBehaviour
{
    public float distance = 50f;
    public float speed = 1;
    public GameObject ball;
    
    public float power = 2000;

    private bool ready = false;
    private bool fire = false;
    private float moveCount = 0;


    
    public float distance2 = 50f;
    public float speed2 = 1;
    public GameObject ball2;
    public float power2 = 2000;
    private bool ready2 = false;
    private bool fire2 = false;
    private float moveCount2 = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            ready = true;
        }
        if (collision.gameObject.CompareTag("ball2"))
        {
            ready2 = true;
        }
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (moveCount < distance)
            {
                transform.Translate(0, 0, -speed * Time.deltaTime);
                moveCount += speed * Time.deltaTime;
                fire = true;
            }
        }

        else if (moveCount > 0)
        {
            if (fire && ready)
            {
                ball.transform.TransformDirection(Vector3.forward * 10);
                ball.GetComponent<Rigidbody>().AddForce(0, 0, moveCount * power);
                fire = false;
                ready = false;
            }
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount -= 20 * Time.deltaTime;

        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            if (moveCount2 < distance2)
            {
                transform.Translate(0, 0, -speed2 * Time.deltaTime);
                moveCount2 += speed2 * Time.deltaTime;
                fire2 = true;
            }
        }

        else if (moveCount2 > 0)
        {
            if (fire2 && ready2)
            {
                ball2.transform.TransformDirection(Vector3.forward * 10);
                ball2.GetComponent<Rigidbody>().AddForce(0, 0, moveCount2 * power2);
                fire2 = false;
                ready2 = false;
            }
            transform.Translate(0, 0, 20 * Time.deltaTime);
            moveCount2 -= 20 * Time.deltaTime;

        }
    }
    private void FixedUpdate()
    {
        
    }

       



    }

