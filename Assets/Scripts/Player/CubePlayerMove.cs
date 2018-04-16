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

    public static bool canDoubleJump;
   //private bool inAir;
    private bool isDoubleJumping;
    //holds the time at which doublejump was last activated
    private float doubletime;
    //holds the time at which bigguy powerup was last activated
    private float bigtime;
    //holds the amount of time after which a powerup needs to be refreshed
    public float PowerupActiveDuration;
    private bool bigactive;
    void Start()
    {
        //store the rigidbody for later use
        r = gameObject.GetComponent<Rigidbody>();
        canDoubleJump = false;
        isDoubleJumping = false;
        //inAir = false;
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
        
        if (Input.GetButtonDown("Jump") && wait >= jumpDelay)
        {
            wait = 0;
            waiting = false;
            r.AddForce(new Vector3(0, jump, 0));
        }
        //checking if the player wants to double jump and hasn't double jumped yet
        if (Input.GetButtonDown("Jump") && canDoubleJump == true && isDoubleJumping == false) {
            //making them jump
            r.AddForce(new Vector3(0,jump,0));
            isDoubleJumping = true;
            //inAir = true;
        
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
            if(c.gameObject.name == "bigguy"){
                gameObject.transform.localScale += new Vector3(2.0f, 2.0f, 2.0f);
            }
            if(c.gameObject.name == "doublejump"){
                canDoubleJump = true;
                doubletime = Time.time;
            }
        }
        else{
        //when the player lands start waiting
            colliders.Add(c);
            waiting = true;
            isDoubleJumping = false;
            //inAir = false;
            //checks to see if doublejump should be deactivated because it has been active for to long
            if (Time.time - doubletime > PowerupActiveDuration){
                canDoubleJump = false;
            }
            if(Time.time - bigtime > PowerupActiveDuration){
                if(bigactive){
                    bigactive = false;
                }
            }
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