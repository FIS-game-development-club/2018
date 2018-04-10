using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayerMove : MonoBehaviour
{

    //set player properties
    public float speed;
    public float jump;
    Rigidbody r;
    bool waiting = false;
    public float wait = 0f;
    public float jumpDelay = 0.1f;

    void Start()
    {
        //store the rigidbody for later use
        r = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //keeps track of the time since the player started waiting
        if (waiting)
            wait += Time.deltaTime;

        //player movement (only when key is pressed)
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, 1.0f * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -1.0f * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(Vector3.down);
        }
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(Vector3.up);
        }

        //only jump if the player has waited longer than jump delay
        if (Input.GetKey(KeyCode.Space) && wait >= jumpDelay)
        {
            wait = 0;
            waiting = false;
            r.AddForce(new Vector3(0, jump, 0));
        }
    }

    List<Collider> colliders = new List<Collider>();

    void OnTriggerEnter(Collider c)
    {
        //checks if the player is colliding with a powerup
        if (c.gameObject.CompareTag("Powerup"))
        {
            //removes the powerup from the scene
            c.gameObject.SetActive(false);
        }
        else{
        //when the player lands start waiting
            colliders.Add(c);
            waiting = true;
        }
    }
    void OnTriggerExit(Collider c)
    {
        //stop waiting and reset if the player falls
        colliders.Remove(c);
        if (colliders.Count == 0)
        {
            waiting = false;
            wait = 0;
        }
    }

  
}