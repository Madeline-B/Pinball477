using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSynch : MonoBehaviour
{
	public int HighScore = 0;
	public GameObject Score;
	public GameObject PScore;
	public GameObject HScore;
	public TMP_Text txt;
	public TMP_Text ptxt;
	public TMP_Text htxt;
	
    // Start is called before the first frame update
    void Start()
    {
        txt = Score.GetComponent<TextMeshPro>();
		
	}

    // Update is called once per frame
    void Update()
    {
		ptxt = PScore.GetComponent<TextMeshProUGUI>();
        ptxt.text = txt.text;
		htxt = HScore.GetComponent<TextMeshProUGUI>();
		if(int.Parse(ptxt.text) > int.Parse(htxt.text)){
			htxt = HScore.GetComponent<TextMeshProUGUI>();
			htxt.text = txt.text;			
		}

    }
}
