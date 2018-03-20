using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class EventSystemScript : MonoBehaviour 
{
	EventSystem event_system;

	void Start()
	{
		event_system = GameObject.Find("EventSystem").GetComponent<EventSystem>();
	}

	public void clear_selection()
	{
		event_system.SetSelectedGameObject(null);
	}
}
