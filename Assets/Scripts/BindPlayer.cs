using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindPlayer : MonoBehaviour 
{

	void OnTriggerEnter(Collider c)
	{
		GameObject g = c.gameObject;
		if (g.name == "CubePlayer")
		{
			g.transform.SetParent(transform);
		}
	}
}
