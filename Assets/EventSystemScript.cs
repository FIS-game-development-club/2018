using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class EventSystemScript : MonoBehaviour 
{
	public EventSystem event_system;

	public void clear_selection()
	{
		event_system.SetSelectedGameObject(null);
	}
}
