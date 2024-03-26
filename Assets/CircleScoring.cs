using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CircleScoring : MonoBehaviour
{
	private int amountAdded = 0;
	public GameObject Score;
	public TMP_Text txt;
	
	public void OnTriggerEnter(Collider other){
		amountAdded = int.Parse(txt.text) + 100;
		txt.text = amountAdded.ToString();
	}
	
    // Start is called before the first frame update
    void Start()
    {
        txt = Score.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
