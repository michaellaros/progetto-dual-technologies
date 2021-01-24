using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doublepalla : MonoBehaviour
{
    public GameObject zona;
    public GameObject palla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.CompareTag("ball"))
            Instantiate(palla, zona.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
