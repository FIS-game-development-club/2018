using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public string scene;
    public int Levelnumber;
    public GameObject scenemanager;
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            if()
            SceneManager.LoadScene(scene);
            if (PlayerPrefs.GetInt("Levelnumber", 1) >= Levelnumber){
                PlayerPrefs.SetInt("Levelnumber", Levelnumber + 1);
            }
        }
    }
}