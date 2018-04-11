using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballs : MonoBehaviour {

    Deathmenu deathmenu;
    ParticleSystem particlesystem;

 	void Start () {
        
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
        particlesystem = gameObject.GetComponent<ParticleSystem>();
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
            particlesystem.Clear(false);
        }
    }
}
