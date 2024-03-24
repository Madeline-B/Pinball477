using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProcess : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject GameOver;
	public GameObject Pinball;
	
	public void StartGameClicked(){
		MainMenu.SetActive(false);
		Pinball.SetActive(true);
	}
	
	public void RestartClicked(){
		MainMenu.SetActive(true);
		GameOver.SetActive(false);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
		Pinball.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	
}
