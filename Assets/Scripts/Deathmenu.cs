using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathmenu : MonoBehaviour {
    public GameObject Deathmenu;
    public void respawnX = 0;
    public void respawnY = 0;
    public void respawnZ = 0;

    public void died(){
        Deathmenu.SetActive(true);
        Time.timeScale = 0;
    }
}
