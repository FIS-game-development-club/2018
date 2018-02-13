using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour 
{
    Deathmenu deathmenu;

    void Start()
    {
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
    }

    void OnTriggerEnter(Collider c)
	{
        if (c.gameObject.name == "CubePlayer") {
            deathmenu.died();
		}
	
	}
}
