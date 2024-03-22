using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProcess : MonoBehaviour
{
	public GameObject MainMenu;
	public GameObject GameOver;
	
	public void StartGameClicked(){
		MainMenu.SetActive(false);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
	
}
