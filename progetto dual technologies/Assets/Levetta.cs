﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levetta : MonoBehaviour
{
    public GameObject levetta;
    public float forza = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("levetta") && Input.GetKey(KeyCode.K))
        {
            
            {
                Debug.Log("hospinto");
                GetComponent<Rigidbody>().AddForce(0,0,5000);
            }
        }
    }
}
