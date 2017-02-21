using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class taptapRules : MonoBehaviour {
	public Button whiteB, blackB;
	public GameObject pBarW, pBarB, counter;
	public int clickGoal = 0, blackTap, whiteTap, timeTill = 3;
	//public float speed = .5f;
	public string winner;
	public bool hasBegun, gameOver;
	public Animator anim;
	public GameObject constant;
	public Gyroscope gyro;

	// Use this for initialization
	void Start () {
		whiteB = GameObject.Find("Canvas/white").GetComponent<Button>();
		blackB = GameObject.Find("Canvas/black").GetComponent<Button>();
		pBarW = GameObject.Find("finishLines/whiteP");
		pBarB = GameObject.Find("finishLines/blackP");
		constant = GameObject.Find("constant");

		counter = GameObject.Find("Canvas/counter");
		gameOver = false;
		hasBegun = false;
		anim = GameObject.Find("Canvas").GetComponent<Animator>();
		Destroy(constant);

		if (SystemInfo.supportsGyroscope) {
             gyro = Input.gyro;
             gyro.enabled = true;
         }

		}

	// Update is called once per frame
	void Update () {
		//Determines whos winning
		Debug.Log(Input.gyro.attitude);
		hasBegun = counter.GetComponent<countDown>().hasStarted;
		if (pBarW != null && pBarB != null) {
			if (pBarW.transform.position.y <= 0) {
				winner = pBarW.name;
				finish(winner);
			} else if (pBarB.transform.position.y >= 0) {
				winner = pBarB.name;
				finish(winner);
			}
		}
	}

	public void onClick () {
		//pBarW goes down (Left); pBarB goes up (Left);
		//Determining Factor
		if (gameOver == false && hasBegun == true) {
			if (gameObject.name == "white") {
				pBarW.transform.Translate(0, -0.5f, 0);
			} else if (gameObject.name == "black" && hasBegun == true) {
				pBarB.transform.Translate(0, 0.5f, 0);
			}
		}

		if (gameOver == true && hasBegun == true) {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("blackWin") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f || anim.GetCurrentAnimatorStateInfo(0).IsName("whiteWin") &&
					anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f ) {
							Application.LoadLevel("mainMenu");
			}
		}
	}

	public string finish (string winName) {
		gameOver = true;
		pBarW.SetActive(false);
		pBarB.SetActive(false);
		if (winName == pBarW.name) {
			anim.SetInteger("winner", 1);
		} else if (winName == pBarB.name) {
			anim.SetInteger("winner", 2);
		}
		return winName;
	}
}
