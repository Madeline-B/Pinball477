using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlip : MonoBehaviour
{
	public GameObject RightFlipper;
	public float resting = 0f;
	public float dampen = 150f;
	public float strength = 10000f;
	public float pressed = 45f;
	HingeJoint hinge;
	
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
		hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
		JointSpring spring = new JointSpring();
		spring.spring = strength;
		spring.damper = dampen;
		
        if (Input.GetKeyDown(KeyCode.RightArrow)){
			spring.targetPosition = pressed;
		}else{
			spring.targetPosition = resting;
		}
		
		hinge.spring = spring;
		hinge.useLimits = true;
    }
}
