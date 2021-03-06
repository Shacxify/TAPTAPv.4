﻿using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OLDbuttonDirection : MonoBehaviour {

	public gameMode gm;
	public Animator anim;

	// Use this for initialization
	void Update () {
		if (Application.loadedLevelName == "mainMenu") {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("reverseToSelect") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) {
				Application.LoadLevel("readyUp");
			}
		}
	}

	void Awake () {
		if (Application.loadedLevelName == "mainMenu") {
			anim = GameObject.Find("/bg").GetComponent<Animator>();
		} else if (Application.loadedLevelName == "menu") {
			anim = GameObject.Find("Canvas/bg").GetComponent<Animator>();
		} else if (Application.loadedLevelName == "TAPTAP") {
			//anim = GameObject.Find
		} else {
			anim = null;
		}
	}

	public void onClick () {

		if (gameObject.name == "settings") {
			Application.LoadLevel("settings");
		} else if (gameObject.name == "play") {
			anim.SetBool("start", true);
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("outStart")) {
				anim.speed = 2;
				Application.LoadLevel("mainMenu");
			}
		} else if (gameObject.name == "TAPTAP") {
			gm = GameObject.Find("/constant").GetComponent<gameMode>();
			anim.SetInteger("sceneChoice", 1);
			gm.game = 1;
		} else if (gameObject.name == "restartW" || gameObject.name == "restartB") {
			Application.LoadLevel("readyUp");
		}

	}

}
