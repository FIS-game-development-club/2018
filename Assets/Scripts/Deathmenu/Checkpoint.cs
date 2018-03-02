using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    GameObject spawnpoint;
    bool usable = true;
    Spawnpoint script;
    void Start()
    {
        spawnpoint = GameObject.Find("Spawnpoint");
        script = GameObject.Find("SceneManager").GetComponent<Spawnpoint>();
    }
    void OnTriggerEnter(Collider c)
    {
        if (usable)
        {
            if (c.gameObject.name == "CubePlayer")
            {
                script.setspawnpoint(gameObject);
            }
        }
    }
}