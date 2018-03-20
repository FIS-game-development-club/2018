using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    public int levelnumber;
    public Text highscore;
    public Text time;
    public float score;

	void Start()
	{
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore " + levelnumber.ToString(), 0);
	}
	void Update () {
        score += Time.deltaTime;
        if ((Mathf.Round(score * 10) / 10) % 1 == 0)
        {
            time.text = "Score: " + (Mathf.Round(score * 10) / 10) + ".0s";
        }
        else
        {
            time.text = "Score: " + (Mathf.Round(score * 10) / 10) + "s";
        }
	}
}