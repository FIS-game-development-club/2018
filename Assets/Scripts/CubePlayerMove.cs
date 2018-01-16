using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			gameObject.transform.Translate (Vector3.forward * Time.deltaTime * 5);
		}

		if (Input.GetKey(KeyCode.A))
		{
			gameObject.transform.Translate (Vector3.left * Time.deltaTime * 5);
		}

		if (Input.GetKey(KeyCode.S))
		{
			gameObject.transform.Translate (Vector3.back * Time.deltaTime * 5);
		}

		if (Input.GetKey(KeyCode.D))
		{
			gameObject.transform.Translate (Vector3.right * Time.deltaTime * 5);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			gameObject.transform.Translate (Vector3.up * 2);
		}

		if (Input.GetKey (KeyCode.Q)) {
			gameObject.transform.Rotate (Vector3.down);
		}

		if (Input.GetKey (KeyCode.E)) {
			gameObject.transform.Rotate (Vector3.up);
		}
}

}
