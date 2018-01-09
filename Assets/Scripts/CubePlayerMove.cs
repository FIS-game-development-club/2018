using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.W))
		{
			gameObject.transform.Translate(Vector3.forward);
		}
	}
}
