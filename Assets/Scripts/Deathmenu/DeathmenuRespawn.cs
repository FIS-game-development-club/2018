using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathmenuRespawn : MonoBehaviour 
{
	Deathmenu death_menu;

	void Start()
	{
		death_menu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}

	public void on_click()
	{
		death_menu.respawn();
	}
}
