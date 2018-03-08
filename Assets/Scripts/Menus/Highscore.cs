using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    public int levelnumber;
    public Text highscore;
    int highscoreint;
    public Text time;
    public int score;

    void FixedUpdate () {
        highscoreint = PlayerPrefs.GetInt("highscore " + levelnumber.ToString(), 0);
        highscore.text = "Highscore: " + highscoreint.ToString();
        score = (int)Time.deltaTime;
        time.text = score.ToString();
	}
}
