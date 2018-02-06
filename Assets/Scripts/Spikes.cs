using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour 
{
    Pausemenu pausemenu;

    void Start()
    {
        pausemenu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
    }

    void OnCollisionEnter(Collision collide)
	{
        if (collide.gameObject.name == "CubePlayer") {
			Debug.Log ("Player died");
            pausemenu.pause ();
		}
	
	}
}
