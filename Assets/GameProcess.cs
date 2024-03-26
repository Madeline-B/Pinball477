using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameProcess : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject GameOver;
	public GameObject Pinball;
	public GameObject Music;
	public GameObject Score;
	public TMP_Text txt;
	
	public void StartGameClicked(){
		MainMenu.SetActive(false);
		Pinball.SetActive(true);
		Music.SetActive(true);
	}
	
	public void RestartClicked(){
		MainMenu.SetActive(true);
		GameOver.SetActive(false);
		Music.SetActive(false);
		txt.text = "0";
	}
	
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
		Pinball.SetActive(false);
		Music.SetActive(false);
		txt = Score.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	
}
