using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour {
	public static bool paused = false;
	public GameObject PauseMenu;

	public void resume(){
		PauseMenu.SetActive (false);
		Time.timeScale = 1;
		paused = false;
	}
	public void pause (){
		PauseMenu.SetActive (true);
		Time.timeScale = 0;
		paused = true;
	}
	void Start () {
		PauseMenu.SetActive (false);
	}
		
		void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if(paused){
				resume ();
			}
			else{
				pause();
			}
		}
	}
}