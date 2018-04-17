using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour 
{
	public float speed;
	public float duration;
	float lifetime;
	ParticleSystem ps;
	float fulllife;
	Deathmenu kill;
	void Start () 
	{
		speed = Random.Range(speed - 2, speed +2);
		if(speed > 0 ){
			speed *= -1;
		}
		//randomize speed
		ps = gameObject.GetComponent<ParticleSystem>();
		fulllife = ps.startLifetime;
		kill = GameObject.Find("SceneManager").GetComponent<Deathmenu>();

	}
	
	void Update () 
	{
		if (lifetime >= duration)
			GameObject.Destroy(gameObject);
		else
		{
			lifetime += Time.deltaTime;
			ps.startLifetime = fulllife * (1 - (lifetime / duration));
			transform.Translate(gameObject.transform.forward * speed * Time.deltaTime);
		}
		
	}
	void OnTriggerEnter(Collider c){
		if (c.name == "CubePlayer"){
			kill.died();
		}
		GameObject.Destroy(gameObject);
	}
}
