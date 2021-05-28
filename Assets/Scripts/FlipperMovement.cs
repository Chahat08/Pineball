using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperMovement : MonoBehaviour
{
    public GameObject point;
    public float angle = 30f;
    private Vector3 axis = new Vector3(0, 0, 1);

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;

    HingeJoint hinge;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }


    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey("a"))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
