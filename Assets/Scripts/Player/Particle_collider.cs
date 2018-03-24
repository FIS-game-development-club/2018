using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_collider : MonoBehaviour {

    Deathmenu kill;
	// Use this for initialization
	void Start () {
        kill = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnParticleTrigger()
	{
		
	}
}
