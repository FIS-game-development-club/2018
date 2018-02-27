using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikemove : MonoBehaviour 
{
	public float time_up;
	public float time_down;
	public GameObject up_position;
	public GameObject down_position;
	public float shift_speed;

	float time_elapsed;
	public bool isUp;

	void Update () 
	{
		time_elapsed += Time.deltaTime;
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

		if (isUp) {
			gameObject.transform.position = 
				Vector3.Lerp (
					down_position.transform.position,
					up_position.transform.position,
					1 / shift_speed * time_elapsed);
		} 
		else 
		{
			gameObject.transform.position = 
				Vector3.Lerp (
					up_position.transform.position,
					down_position.transform.position,
					1 / shift_speed * time_elapsed);
		}
	}
}
