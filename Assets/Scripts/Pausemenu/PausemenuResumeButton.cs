using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausemenuResumeButton : MonoBehaviour 
{
	Pausemenu pause_menu;

	void Start()
	{
		pause_menu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
	}

	public void on_click()
	{
		pause_menu.resume();
	}
}
