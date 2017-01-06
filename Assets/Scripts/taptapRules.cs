using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class taptapRules : MonoBehaviour {
	public Button whiteB, blackB;
	public GameObject pBarW, pBarB, counter;
	public int clickGoal = 0, blackTap, whiteTap, timeTill = 3;
	public string winner;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		whiteB = GameObject.Find("Canvas/white").GetComponent<Button>();
		blackB = GameObject.Find("Canvas/black").GetComponent<Button>();
		pBarW = GameObject.Find("finishLines/whiteP");
		pBarB = GameObject.Find("finishLines/blackP");

		counter = GameObject.Find("Canvas/counter");
		gameOver = false;
		counter.GetComponent<Text>().text = countDown(timeTill);
		}

	// Update is called once per frame
	void Update () {

		//Determines whos winning
		if (pBarW.transform.position.y <= 0) {
			winner = pBarW.name;
			finish(winner);
		} else if (pBarB.transform.position.y >= 0) {
			winner = pBarB.name;
			finish(winner);
		}
	}

	public void onClick () {
		//pBarW goes down (Left); pBarB goes up (Left);
		//Determining Factor
		if (gameOver != true) {
			if (gameObject.name == "white") {
				pBarW.transform.Translate(0, -1, 0);
			} else if (gameObject.name == "black") {
				pBarB.transform.Translate(0, 1, 0);
			}
		}
	}

	public string finish (string winName) {
		gameOver = true;
		return winName;
	}

	public string countDown (int fromNum) {
		while (fromNum != 0) {
			double currentNum = fromNum - Time.deltaTime;
			return currentNum.ToString();
		}
		return "";
	}
}
