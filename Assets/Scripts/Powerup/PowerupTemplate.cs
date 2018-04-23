using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupTemplate : MonoBehaviour {
	//creates the class
	public class Powerup {
		public string type;
		//default constructor
		public Powerup(){
			type = null;
		}
		//constructor
		public Powerup(string ty){
			//sets the type of powerup to the type defined when an object is created
			type = ty;
		}
	}
}
