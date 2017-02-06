using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneDirection : MonoBehaviour {

	public Animation anim;
	public GameObject triggerObject;
	public Scene scene;

	// Use this for initialization
	void Start () {
		Scene scene = SceneManager.GetActiveScene();
		anim = triggerObject.GetComponent<Animation>();
	}

	// Update is called once per frame


	void Update () {
		sceneSelect();
	}

	void sceneSelect (/*int select*/) {
		if (scene.name == "mainMenu") {
			Debug.Log("Woo It Works!");
		}
	}
}
