using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towRules : MonoBehaviour {

	public GameObject white, black;
	public int speed;
	// Use this for initialization
	void Start () {
		white = GameObject.Find("Canvas/white");
		black = GameObject.Find("Canvas/black");
	}



	public void onClick() {
		if (gameObject.name == "black") {
			Debug.Log("OO OO");
		}
		if (gameObject.name == "white") {
			gameObject.translate.Transform(new );
		}
	}
}
