using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathmenu : MonoBehaviour {
    public Canvas death_menu;
    public bool active = false;
    GameObject player;
    GameObject spawn_point;
    Pausemenu pause_menu;
    EventSystemScript event_system;

    void Start()
    {
        //cache the player, spawnpoint and other important objects
        player = GameObject.Find("CubePlayer");
        spawn_point = GameObject.Find("Spawnpoint");
        set_active(false);
        pause_menu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
        event_system = GameObject.Find("SceneManager").GetComponent<EventSystemScript>();
    }

    public void died()
    {
        set_active(true);
        active = true;
        Time.timeScale = 0;
    }

    public void respawn()
    {
        set_active(false);
        player.transform.position = spawn_point.transform.position;
        player.transform.rotation = spawn_point.transform.rotation;
        event_system.clear_selection();
        Time.timeScale = 1;
        active = false;
    }

    public void set_active(bool b)
    {
        death_menu.enabled = b;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && pause_menu.paused == false)
        {
            died();
        }
    }
}