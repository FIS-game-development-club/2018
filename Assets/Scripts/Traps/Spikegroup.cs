using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikegroup : MonoBehaviour {

	public GameObject Position2;
	public float shiftspeed;
	public float timeup;
	public float timedown;
	public float y;
	void Start () {
		y = Position2.transform.position.y;
	}
}
