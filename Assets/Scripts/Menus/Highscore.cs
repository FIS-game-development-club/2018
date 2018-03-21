using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    public int levelnumber;
    public Text highscore;
    public Text time;
    public float score;

	void Update () {
        score += Time.deltaTime;
        highscore.text = "Highscore: " + PlayerPrefs.GetFloat("highscore " + levelnumber, 0) + "s";
        if ((Mathf.Round(score * 10) / 10) % 1 == 0){
            time.text = "Score: " + (Mathf.Round(score * 10) / 10) + ".0s";
        }
        else
        {
            time.text = "Score: " + (Mathf.Round(score * 10) / 10) + "s";
        }
	}
}