using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {

    public GameObject Player;
    public GameObject spawnpoint;

	void Start () {
        spawnpoint = GameObject.Find("Spawnpoint");
        Player = GameObject.Find("CubePlayer");
        spawnpoint.transform.position = Player.transform.position;
        spawnpoint.transform.rotation = Player.transform.rotation;
	}
}
