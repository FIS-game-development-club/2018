using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    bool usable = true;
    Spawnpoint script;
    //checks if the player has got a checkpoint, for the color change script
    public static bool checkpointGot;

    void Start()
    {
        script = GameObject.Find("SceneManager").GetComponent<Spawnpoint>();
        checkpointGot = false;
    }

    //sets the players spawnpoint to the checkpoint
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            if (usable)
            {
                script.setspawnpoint(gameObject);
                usable = false;
                checkpointGot = true;
                
            }
        }
    }
}