using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSynch : MonoBehaviour
{
	public int HighScore = 0;
	public GameObject Score;
	public GameObject PlayerScore;
	public TMP_Text txt;
	public TMP_Text ptxt;
	
    // Start is called before the first frame update
    void Start()
    {
        txt = Score.GetComponent<TextMeshPro>();

	}

    // Update is called once per frame
    void Update()
    {
		ptxt = PlayerScore.GetComponent<TextMeshPro>();
        ptxt.text = txt.text;
    }
}
