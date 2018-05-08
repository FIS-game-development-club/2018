using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reset : MonoBehaviour {
    TextMeshPro text;

	void Awake() {
		text = transform.Find("Text").gameObject.GetComponent<TextMeshPro>();
        text.color = Color.white;
	}

    public void reset()
    {
        PlayerPrefs.DeleteAll();
        text.color = Color.green;
    }
}