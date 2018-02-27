using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemenu : MonoBehaviour 
{
	public bool paused = false;
	public GameObject pause_menu;
    Deathmenu death_menu; 

	public void resume(){
		pause_menu.SetActive (false);
		Time.timeScale = 1;
		paused = false;
	}
	public void pause (){
		pause_menu.SetActive (true);
		Time.timeScale = 0;
		paused = true;
	}
	void Start () {
		pause_menu.SetActive (false);
        death_menu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}
		
	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.Escape) && death_menu.active == false) 
		{
			if(paused)
			{
				resume ();
			}
			else{
				pause();
			}
		}
	}
}