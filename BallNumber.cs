using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallNumber : MonoBehaviour
{
	private int ballCount = 3;
	public GameObject BallSensor;
	public GameObject GameOverMenu;
	public GameObject Pinball;
    
	public void OnTriggerEnter(Collider other){
		ballCount = ballCount - 1;
	}
	
	// Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (ballCount <= 0){
			Pinball.SetActive(false);
			GameOverMenu.SetActive(true);
			ballCount = 3;
		}
    }
}
