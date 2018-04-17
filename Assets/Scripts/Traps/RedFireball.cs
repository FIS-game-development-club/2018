using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFireball : MonoBehaviour 
{
	public float speed;
	public float duration;
	float lifetime;
	ParticleSystem ps;
	float fulllife;
	void Start () 
	{
		ps = gameObject.GetComponent<ParticleSystem>();
		fulllife = ps.startLifetime;
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
}
