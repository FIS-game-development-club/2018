using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerMove : MonoBehaviour {

    public float speed;
    Rigidbody r;
    bool onGround = true;

    void Start ()
    {
        r = gameObject.GetComponent<Rigidbody> ();
    }

    void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey (KeyCode.Space) && onGround)
        {
            r.AddForce (new Vector3 (0, 170, 0));
            onGround = false;
        }
        if (Input.GetKey (KeyCode.W))
        {
            gameObject.transform.Translate (0, 0, 1.0f * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.S))
        {
            gameObject.transform.Translate (0, 0, -1.0f * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        onGround = true;
    }
}