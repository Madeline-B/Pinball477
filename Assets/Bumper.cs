using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bumper : MonoBehaviour {
    // private Renderer ren;
    // private float t;	
    private int amountAdded = 0;
	public GameObject Score;
	public TMP_Text txt;

    void Start() {
        // ren = GetComponent<Renderer>();
        // t = 0;
    }

	public void OnTriggerEnter(Collider other){
		amountAdded = int.Parse(txt.text) + 200;
		txt.text = amountAdded.ToString();
	}
    
    void Update() {
    }
}
