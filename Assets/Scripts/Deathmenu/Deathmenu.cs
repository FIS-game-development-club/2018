using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deathmenu : MonoBehaviour 
{
    Canvas death_menu;
    bool active = false;
    GameObject player;
    GameObject spawn_point;
    Pausemenu pause_menu;
    EventSystemScript event_system;

    void Start()
    {
        //cache the player, spawnpoint and other important objects
        player = GameObject.Find("CubePlayer");
        spawn_point = GameObject.Find("Spawnpoint");
        pause_menu = GameObject.Find("SceneManager").GetComponent<Pausemenu>();
        event_system = gameObject.GetComponent<EventSystemScript>();
        death_menu = GameObject.Find("Deathmenu").GetComponent<Canvas>();
        set_active(false);
    }

    //kills the player
    public void died()
    {
        set_active(true);
        active = true;
        Time.timeScale = 0;
    }

    //player returns to the spawn point
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
        if (Input.GetKeyDown(KeyCode.K) && pause_menu.getPaused() == false)
        {
            died();
        }
    }

    public bool isActive()
    {
        return active;
    }
}