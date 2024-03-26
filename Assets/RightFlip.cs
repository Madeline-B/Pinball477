using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlip : MonoBehaviour
{
	public float resting = 0f;
	public float dampen = 150f;
	public float strength = 10000f;
	public float pressed = 45f;
	public HingeJoint hinge;
	
	
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();		
    }

    // Update is called once per frame
    void Update()
    {
		JointSpring hingeSpring = hinge.spring;
		hingeSpring.spring = strength;
		hingeSpring.damper = dampen;

        if (Input.GetKeyDown(KeyCode.RightArrow)){
			hingeSpring.targetPosition = pressed;
		}else if(Input.GetKeyUp(KeyCode.RightArrow)){
			hingeSpring.targetPosition = resting;
		}
		hinge.useSpring = true;
		hinge.spring = hingeSpring;

    }
}
