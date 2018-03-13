using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

    GameObject Player;
    GameObject spawnpoint;

	void Start() 
    {
        //cahce player and spawn point
        spawnpoint = GameObject.Find("Spawnpoint");
        Player = GameObject.Find("CubePlayer");
        setspawnpoint(Player);
	}

    public void setspawnpoint(GameObject Location)
    {
        //moves the spawn point
        spawnpoint.transform.position = Location.transform.position;
        spawnpoint.transform.rotation = Location.transform.rotation;
    }
}