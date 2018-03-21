using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelselector : MonoBehaviour {

    string level;
    public int levelnumber;
    public Text highscore;

    void Start(){
        highscore.text = "Highscore: " + PlayerPrefs.GetFloat("highscore " + levelnumber, 0) + "s";
        level = "Scenes/Level " + levelnumber;
    }

	public void to_level () {
    
        if (PlayerPrefs.GetFloat("Levelnumber", 1) >= levelnumber)
        {
            SceneManager.LoadScene(level);
        }
	}
}
