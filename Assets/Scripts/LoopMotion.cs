using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMotion : MonoBehaviour 
{
	public List<GameObject> nodes;
	public float delay;
	public float velocity;
	public float angular_velocity;
	int n = 0;
	void Start () 
	{
		n = -1;
		start_next();
		gameObject.transform.position = nodes[0].transform.position;
		gameObject.transform.rotation = nodes[0].transform.rotation;
	}
	
	Vector3 a, b;
	float m;

	float x = 0;
	bool waiting;
	void Update () 
	{
		x += Time.deltaTime * velocity;
		if (waiting && x > 0)
		{
			gameObject.GetComponent<BindPlayer>().clear();
			waiting = false;
		}
		gameObject.transform.position = Vector3.Lerp(a, b,  Mathf.SmoothStep(0.0f, 1.0f, x / m));
		if (x > m)
		{
			x -= m;
			start_next();
		}
	}

	private void start_next()
	{
		n = (n + 1) % nodes.Count;
		a = getNode(n + 1).transform.position;
		b = getNode(n).transform.position;
		Vector3 d = b - a;
		m = d.magnitude;
		x -= delay * velocity;
		waiting = true;
	}

	private GameObject getNode(int i)
	{
		return nodes[i % nodes.Count];
	}
}
