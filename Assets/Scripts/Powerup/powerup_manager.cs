using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_manager : MonoBehaviour {

	Deathmenu deathmenu;
	GameObject[] powerups;
	void Start () {
		deathmenu = GameObject.FindWithTag("Scenemanager").GetComponent<Deathmenu>();
		powerups = GameObject.FindGameObjectsWithTag("Powerup");
	}


	void Update () {
		if (deathmenu.active){
			foreach(GameObject powerup in powerups){
				powerup.SetActive(true);
			}
		}
	}
}