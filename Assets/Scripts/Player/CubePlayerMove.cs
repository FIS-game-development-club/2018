using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerMove : MonoBehaviour {

    public float speed;
	public float jump;
    Rigidbody r;
	bool waiting = false;
	public float wait = 0f;
	public float jumpDelay = 0.1f;

    void Start ()
    {
        r = gameObject.GetComponent<Rigidbody> ();
    }

    void FixedUpdate ()
    {
		if (waiting)
			wait += Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey (KeyCode.W))
        {
            gameObject.transform.Translate (0, 0, 1.0f * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.S))
        {
            gameObject.transform.Translate (0, 0, -1.0f * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.Q)) 
		{
			gameObject.transform.Rotate (Vector3.down);
		}
		if (Input.GetKey (KeyCode.E)) {
			gameObject.transform.Rotate (Vector3.up);
		}
		if (Input.GetKey (KeyCode.Space) && wait >= jumpDelay)
		{
			wait = 0;
			r.AddForce (new Vector3 (0, jump, 0));
		}
    }

	List<Collider> colliders = new List<Collider> ();

	void OnTriggerEnter(Collider c)
	{
		colliders.Add (c);
		waiting = true;
	}

	void OnTriggerExit(Collider c)
	{
		colliders.Remove (c);
		if (colliders.Count == 0) 
		{
			waiting = false;
			wait = 0;
		}
	}
}