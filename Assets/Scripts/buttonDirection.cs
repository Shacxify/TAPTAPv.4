using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonDirection : MonoBehaviour {

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
		} else {
			anim = null;
		}
	}

	public void onClick () {


		if (gameObject.name == "settings") {
			Application.LoadLevel("settings");
		} else if (gameObject.name == "play") {
			Application.LoadLevel("mainMenu");
		} else if (gameObject.name == "TAPTAP") {
			gm = GameObject.Find("/constant").GetComponent<gameMode>();
			anim.SetInteger("sceneChoice", 1);
			gm.game = 1;
		}
	}

}
