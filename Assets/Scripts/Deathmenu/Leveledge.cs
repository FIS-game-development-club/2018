using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveledge : MonoBehaviour {
    Deathmenu deathmenu;

    void Start() {
        deathmenu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
    }
    void OnTriggerExit(Collider c) 
    {
        if (c.gameObject.name == "CubePlayer")
        {
            deathmenu.died();
        }
    }
}