using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public string scene;
    void OnCollisionEnter(Collision collide)
    {
        if (collide.gameObject.name == "CubePlayer")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
