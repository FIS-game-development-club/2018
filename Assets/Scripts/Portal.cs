using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {
    public string scene = "scenes/Levelselector";
    public int Levelnumber;
    Highscore score;

	void Start()
	{
        score = GameObject.Find("SceneManager").GetComponent<Highscore>();
	}
	void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "CubePlayer")
        {
            SceneManager.LoadScene(scene);
            if (PlayerPrefs.GetInt("Levelnumber", 1) >= Levelnumber){
                PlayerPrefs.SetInt("Levelnumber", Levelnumber + 1);
            }
            if (score.score > PlayerPrefs.GetInt("highscore " + Levelnumber.ToString(), 0)){
                PlayerPrefs.SetFloat((Mathf.Round(score.score * 10) / 10));
            }
        }
    }
}