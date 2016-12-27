using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class taptapRules : MonoBehaviour {
	public Button whiteB, blackB;
	public GameObject pBarW, pBarB;
	public int clickGoal = 0, blackTap, whiteTap;
	public string winner;

	// Use this for initialization
	void Start () {
		whiteB = GameObject.Find("Canvas/white").GetComponent<Button>();
		blackB = GameObject.Find("Canvas/black").GetComponent<Button>();
		pBarW = GameObject.Find("finishLines/whiteP");
		pBarB = GameObject.Find("finishLines/blackP");

	}

	// Update is called once per frame
	void Update () {



		//Determines whos winning
		if (pBarW.transform.position.x <= 0) {
			winner = pBarW.name.ToString();
			finish(winner);
		} else if (pBarB.transform.position.x >= 0) {
			winner = pBarB.name.ToString();
			finish(winner);
		}
	}

	public void onClick () {
		//pBarW goes down (Left); pBarB goes up (Left);
		if (gameObject.name == "white") {
			pBarW.transform.Translate(0, -1, 0);
		} else if (gameObject.name == "black") {
			pBarB.transform.Translate(0, 1, 0);
		}
	}

	public string finish (string winName) {
		return winName;
	}
}
