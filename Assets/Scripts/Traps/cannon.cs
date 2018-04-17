using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour {

    GameObject player;
    Transform playerP;
    Transform fireball;
    float shot;
    //time since last shot
    public float delay;
    //time in between shots
    void Start () {
        player = GameObject.Find("CubePlayer");
        playerP = player.transform;
        fireball = transform.Find("fireball");
        shot = -1 * delay;
        }
        
        void Update () {
        transform.LookAt(playerP);
        if(Time.time - shot >= delay){
                Instantiate(Resources.Load("Fireball"), fireball.position, fireball.rotation);
                shot = Time.time;
                delay = Random.Range(delay - 4, delay +4);
		if(delay < 0 ){
		delay *= -1;
		}
        }
        }
}