using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset : MonoBehaviour {
    public TextMeshPro textObject;

	void Awake() {
		textObject = transform.Find("Text").gameObject.GetComponent<TextMeshPro>();
	}

    public void reset()
    {
        PlayerPrefs.DeleteAll();
        textObject.color = Color.green;
    }
}