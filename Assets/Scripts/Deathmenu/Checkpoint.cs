using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject Player;
    public GameObject spawnpoint;

    void Start()
    {
        spawnpoint = GameObject.Find("Spawnpoint");
        Player = GameObject.Find("CubePlayer");
    }
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            spawnpoint.transform.rotation = Player.transform.rotation;
            spawnpoint.transform.position = Player.transform.position;
        }
    }
}