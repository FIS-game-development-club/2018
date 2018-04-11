using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour {

    Deathmenu deathmenu;

 	void Start () {
        
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}

    void OnParticleCollision(GameObject collide)
	{
        if (collide.name == "CubePlayer")
        {
            deathmenu.died();
        }
	}

    void Update(){
        if(deathmenu.active){
            GameObject.clear(false);
        }
    }
}
