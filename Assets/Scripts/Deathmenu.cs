using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathmenu : MonoBehaviour {
    public GameObject deathmenu;
    GameObject Player;
    GameObject Spawnpoint; 


    void Start(){
        Player = GameObject.Find("CubePlayer");
        Spawnpoint = GameObject.Find("Spawnpoint");
        deathmenu.SetActive(false);
    }

    public void died(){
        deathmenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void respawn(){
        deathmenu.SetActive(false);
        Player.transform.position = Spawnpoint.transform.position;
        Time.timeScale = 1;
    }

  
}