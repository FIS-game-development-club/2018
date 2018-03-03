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

    void OnCollisionEnter(Collision collide)
	{
        if (collide.gameObject.name == "CubePlayer") {
            deathmenu.died();
		}
	
	}
}