using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_manager : MonoBehaviour {
	public string Scene;
	public void Scenemanager(){
		SceneManager.LoadScene(Scene);
	}

}
