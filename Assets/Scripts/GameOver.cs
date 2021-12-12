using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	}
	
	void OnGUI(){
		
		//if retry button is pressed load scene 0 the game
		GUI.contentColor = Color.red;
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/4 +150,150,40),"Retry?")){
			Application.LoadLevel(0);
		}
		//and quit button
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/4 +200,150,40),"Quit")){
			Application.Quit();
		}
	}
	
}