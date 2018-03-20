using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindPlayer : MonoBehaviour 
{
	Vector3 l;
	Vector3 v;

	void FixedUpdate()
	{
		Vector3 n = gameObject.transform.position;
		v = n - l;
		l = n;
	}

	void OnTriggerEnter(Collider c)
	{
		GameObject g = c.gameObject;
		if (g.name == "CubePlayer")
		{
			if (removed.Contains(g))
				removed.Remove(g);
			g.transform.SetParent(transform);
		}
	}

	List<GameObject> removed = new List<GameObject>();
	void OnTriggerExit(Collider c)
	{
		GameObject g = c.gameObject;
		if (g.name == "CubePlayer")
		{
			removed.Add(g);
		}
	}

	public void clear()
	{
		foreach (GameObject g in removed)
		{
			if (g.transform.parent == transform)
				g.transform.SetParent(null);
		}
		removed.Clear();
	}
}
