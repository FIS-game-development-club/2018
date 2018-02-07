using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour {
	public bool paused = false;
	public GameObject PauseMenu;
    Deathmenu deathmenu; 

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
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}
		
		void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && deathmenu.active == false) {
			if(paused){
				resume ();
			}
			else{
				pause();
			}
		}
	}
}