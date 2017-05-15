using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDirection : MonoBehaviour {

	//public gameMode gm;
	public Animator anim;

	// Use this for initialization
	void Awake () {
		//Assign the anim variable
		if (Application.loadedLevelName == "1menu") {
			anim = GameObject.Find("bg").GetComponent<Animator>();
		} else if (Application.loadedLevelName == "2mainMenu") {
			anim = GameObject.Find("Canvas").GetComponent<Animator>();
		}
	}

	// Update is called once per frame
	void Update () {
		//Loading Menu; Checking for "exit" animation to end.
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("exit")) {
			if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1) {
				Application.LoadLevel("2mainMenu");
			}
		}
	}

	public void onClick () {
		if (gameObject.name == "play") {
			anim.SetTrigger("go");
		}

		//Checking player chosen gamemode;
		if (gameObject.name == "TAP") {
			GameObject.Find("constant").GetComponent<gameMode>().game = 1;
			anim.SetTrigger("gmSelected");
		} else if (gameObject.name == "TOW") {
			GameObject.Find("constant").GetComponent<gameMode>().game = 2;
			anim.SetTrigger("gmSelected");
		}
	}
}
