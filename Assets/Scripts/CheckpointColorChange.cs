using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckpointColorChange : MonoBehaviour {
	//the TextMeshPro object to be changed
	private TextMeshPro textObject;
	//sets the TMPro object to the TMPro object attached to the GameObject and sets it's color to red
	void Awake() {
		textObject = GetComponent<TextMeshPro>();
		textObject.color = Color.red;
	}

	void Update() {
		//sets the text coor to gree when the player gets the checkpoint
		if (Checkpoint.checkpointGot) {
			textObject.color = Color.green;
			Checkpoint.checkpointGot = false;
		}
	}

}