using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikemove : MonoBehaviour 
{
	public float time_up;
	public float time_down;
	public GameObject position1;
	public GameObject position2;
	public float shift_speed;
	float time_elapsed;
	bool isUp;
	public GameObject parent;
	Spikegroup group;

	void Start(){
		position1.transform.position = gameObject.transform.position;
		if(parent != null){
			group = parent.GetComponent<Spikegroup>();
			shift_speed = group.shiftspeed;
			time_up = group.timeup;
			time_down = group.timedown;
			position2.transform.position = new Vector3(position2.transform.position.x, group.y, position2.transform.position.z);
		}
	}
	void Update () 
	{
		//keep track of time
		time_elapsed += Time.deltaTime;
		//switch directions if nessesary
		if (isUp) 
		{
			if (time_elapsed > time_up) 
			{
				isUp = false;
				time_elapsed -= time_up;
			}
		}
		else
		{
			if (time_elapsed > time_down)
			{
				isUp = true;
				time_elapsed -= time_down;
			}
		}

		//move up or down if nessesary
		if (isUp) {
			gameObject.transform.position = 
				Vector3.Lerp (
					position2.transform.position,
					position1.transform.position,
					1 / shift_speed * time_elapsed);
		} 
		else 
		{
			gameObject.transform.position = 
				Vector3.Lerp (
					position1.transform.position,
					position2.transform.position,
					1 / shift_speed * time_elapsed);
		}
	}
}
