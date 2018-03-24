using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    GameObject player;
    Transform playerP;
    float delay;

    void Start () {
        player = GameObject.Find("CubePlayer");
        playerP = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(playerP);
	}
}