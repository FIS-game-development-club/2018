using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathmenu : MonoBehaviour {
    public GameObject death_menu;
    public bool active = false;
    GameObject player;
    GameObject spawn_point;
    Pausemenu pause_menu;

    void Start(){
        player = GameObject.Find("CubePlayer");
        spawn_point = GameObject.Find("Spawnpoint");
        death_menu.SetActive(false);
        pause_menu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
    }

    public void died(){
        death_menu.SetActive(true);
        Time.timeScale = 0;
        active = true;
    }

    public void respawn(){
        death_menu.SetActive(false);
        player.transform.position = spawn_point.transform.position;
        player.transform.rotation = spawn_point.transform.rotation;
        Time.timeScale = 1;
        active = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && pause_menu.paused == false)
        {
            died();
        }
    }
}