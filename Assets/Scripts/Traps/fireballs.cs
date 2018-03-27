using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour {

    Deathmenu deathmenu;

 	void Start () {
        
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}

	private void OnParticleCollision(GameObject collide)
	{
        if (collide.name == "CubePlayer")
        {
            deathmenu.died();
        }
	}
}
