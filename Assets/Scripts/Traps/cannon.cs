using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    GameObject player;
    Transform playerP;
    void Start () {
        player = GameObject.Find("CubePlayer");
        playerP = player.transform;
	}
	
	void Update () {
        transform.LookAt(playerP);
	}
}