using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    bool usable = true;
    Spawnpoint script;

    void Start()
    {
        script = GameObject.Find("SceneManager").GetComponent<Spawnpoint>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            if (usable)
            {
                script.setspawnpoint(gameObject);
                usable = false;
            }
        }
    }
}