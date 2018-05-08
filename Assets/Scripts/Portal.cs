using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public string scene = "scenes/Menus/Level selector";
    int Levelnumber;
    Highscore score;

	void Start()
	{
        score = GameObject.Find("SceneManager").GetComponent<Highscore>();
        Levelnumber = score.levelnumber;
	}

	void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            if ((score.score < PlayerPrefs.GetFloat("highscore " + Levelnumber, 0)) ||
                (PlayerPrefs.GetFloat("highscore " + Levelnumber, 0) <= 0)){
                PlayerPrefs.SetFloat("highscore " + Levelnumber, Mathf.Round(score.score * 10) / 10);
            }
            SceneManager.LoadScene(scene);
        }
    }
}