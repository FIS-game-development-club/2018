using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathmenu : MonoBehaviour {
    public GameObject deathmenu;
    public bool active = false;
    GameObject Player;
    GameObject Spawnpoint;
    Pausemenu pausemenu;

    void Start(){
        Player = GameObject.Find("CubePlayer");
        Spawnpoint = GameObject.Find("Spawnpoint");
        deathmenu.SetActive(false);
        pausemenu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
    }

    public void died(){
        deathmenu.SetActive(true);
        Time.timeScale = 0;
        active = true;
    }

    public void respawn(){
        deathmenu.SetActive(false);
        Player.transform.position = Spawnpoint.transform.position;
        Time.timeScale = 1;
        active = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && pausemenu.paused == false){
            died();
        }
    }
}