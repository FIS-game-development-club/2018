using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public string scene;
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            SceneManager.LoadScene(scene);
        }
    }
}