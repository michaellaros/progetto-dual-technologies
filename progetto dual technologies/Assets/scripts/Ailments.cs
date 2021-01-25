using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ailments : MonoBehaviour
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
        left = GameObject.Find("lleftpivot");
        right = GameObject.Find("lrightpivot");
    }

    // Update is called once per frame
    void Update()
    {
        Freeze();
    }

    public void FreezeAilment()
    {
            timer = true;
            left.GetComponent<Left>().movementSpeed = 10f;
            right.GetComponent<Right>().movementSpeed = 10f;
    }

    private void Freeze()
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
}
