using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class buttonDirection : MonoBehaviour {

	public gameMode gm;
	public Animator anim;

	// Use this for initialization
	void Update () {

		if (Application.loadedLevelName == "menu" && anim.GetCurrentAnimatorStateInfo(0).IsName("outStart")) {
			if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
					Application.LoadLevel("mainMenu");
					Debug.Log("LMAO");
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
		} else if (gameObject.name == "TAPTAP") {
			gm = GameObject.Find("/constant").GetComponent<gameMode>();
			anim.SetInteger("sceneChoice", 1);
			gm.game = 1;
			Application.LoadLevel("readyUp");
		}	else if (gameObject.name == "TOW") {
			gm = GameObject.Find("/constant").GetComponent<gameMode>();
			anim.SetInteger("sceneChoice", 2);
			gm.game = 2;
			Application.LoadLevel("readyUp");
		} else if (gameObject.name == "restartW" || gameObject.name == "restartB") {
			Application.LoadLevel("readyUp");
		}

	}

}
