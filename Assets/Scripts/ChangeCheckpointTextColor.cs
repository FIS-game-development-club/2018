using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextColor : MonoBehaviour {


	private TextMeshPro textObject;
	// Use this for initialization

	void Awake() {
		textObject = GetComponent<TextMeshPro>();
		textObject.color = Color.red;
		print("" + textObject.color);
	}

	void Update() {
		if (Checkpoint.checkpointGot) {
			textObject.color = Color.green;
		}
	}


}
