using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelselector : MonoBehaviour {

    public string level;
    public int levelnumber;
    public Text highscore;
    int Highscore;

    void Update(){
        Highscore = PlayerPrefs.GetInt("highscore " + levelnumber.ToString(), 0);
        highscore.text = "Highscore: " + Highscore.ToString();
    }
	public void to_level () {
        if (PlayerPrefs.GetInt("Levelnumber", 1) >= levelnumber)
        {
            SceneManager.LoadScene(level);
        }
	}
}
