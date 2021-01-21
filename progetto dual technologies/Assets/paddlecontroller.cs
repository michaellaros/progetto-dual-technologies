using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class paddlecontroller : MonoBehaviour
{
    public float restPosition;
    public float pressedPosition;
    public float flipperStrength;
    public float flipperDamper;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<HingeJoint>().useSpring = true;

    }
    // Update is called once per frame
    void Update()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointLimits limits = hinge.limits;
        JointSpring spring = new JointSpring();
        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if (Input.GetMouseButtonDown(0))
        {
            spring.targetPosition = pressedPosition;
            Debug.Log("hai premuto");
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        GetComponent<HingeJoint>().spring = spring;
        GetComponent<HingeJoint>().useLimits = true;
        limits.min = restPosition;
        limits.max = pressedPosition;
    }
}

