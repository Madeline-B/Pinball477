using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public GameObject Pinball;
	private Rigidbody rb;
	public GameObject BallSensor;
	public bool ballLaunched = false;
	
	public void OnTriggerEnter(Collider other){
		ballLaunched = false;
		Pinball.transform.position = new Vector3(-0.974f,0.807f,-4.475f);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballLaunched == false) {
			rb.AddForce(new Vector3(0,0,-10), ForceMode.Impulse);
			ballLaunched = true;
		}
    }
}
