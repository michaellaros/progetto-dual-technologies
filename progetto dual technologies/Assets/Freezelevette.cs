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
    private MeshRenderer meshRenderer;
    private BoxCollider meshCollider;
    // Start is called before the first frame update
    void Start()
    {
        left.GetComponent<Left>().movementSpeed = 0.5f;
        right.GetComponent<Right>().movementSpeed = 0.5f;
        currentTime = startingTime;
        meshRenderer = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<BoxCollider>();
        left = GameObject.Find("lleftpivot");
        right = GameObject.Find("lrightpivot");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer)
        {
            currentTime -= 1 * Time.deltaTime;
        }

        if (currentTime <= 0f)
        {
            left.GetComponent<Left>().movementSpeed = 0.5f;
            right.GetComponent<Right>().movementSpeed = 0.5f;
            timer = false;
            currentTime = startingTime;
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
        meshRenderer.enabled = !meshRenderer.enabled;
        meshCollider.enabled = !meshCollider.enabled;


    }
}
