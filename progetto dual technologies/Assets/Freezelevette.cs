using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezelevette : MonoBehaviour
{
    private GameObject Sender;
    private MeshRenderer meshRenderer;
    private BoxCollider meshCollider;
    public bool collide;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<BoxCollider>();
        Sender = GameObject.FindGameObjectWithTag("Sender");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            gameObject.GetComponent<Sender>().SenderSyncFreeze(); 
            collide = true;
        }
        meshRenderer.enabled = !meshRenderer.enabled;
        meshCollider.enabled = !meshCollider.enabled;
    }
}
