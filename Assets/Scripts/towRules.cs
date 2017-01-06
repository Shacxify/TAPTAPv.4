using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towRules : MonoBehaviour {

	public GameObject white, black;

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
			Debug.Log("AA AA");
		}
	}
}
