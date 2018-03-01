using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour 
{
	public bool paused = false;
	public Canvas pause_menu;
    Deathmenu death_menu; 

	public void resume(){
		set_active(false);
		Time.timeScale = 1;
		paused = false;
	}
	public void pause (){
		set_active(true);
		Time.timeScale = 0;
		paused = true;
	}
	void Start () {
		set_active(false);
        death_menu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}

	public void set_active(bool b)
    {
        pause_menu.enabled = b;
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