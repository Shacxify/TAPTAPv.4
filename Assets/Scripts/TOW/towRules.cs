using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towRules : MonoBehaviour {

	public GameObject white, black, sides;
	public float speed;
	public bool gameOver = false;
	public string winner;
	public Animator anim;
	// Use this for initialization
	void Start () {
		white = GameObject.Find("Canvas/sides/white");
		black = GameObject.Find("Canvas/sides/black");
		sides = GameObject.Find("Canvas/sides");
		anim = GameObject.Find("Canvas").GetComponent<Animator>();
	}

	void Update () {
		//hasBegun = counter.GetComponent<countDown>().hasStarted;
		if (white.transform.localPosition.x > -800) {
			winner = "white";
			gameOver = true;
			anim.SetInteger("winner", 1);
		}
		if (black.transform.localPosition.x < 800) {
			winner = "black";
			gameOver = true;
			anim.SetInteger("winner", 2);
		}
		if (gameOver == true) {
			Debug.Log("The winner is " + winner);
		}
	}

	public void toMove() {
		if (gameOver == false) {
			if (gameObject.name == "black") {
				white.transform.Translate(speed * -1, 0, 0);
				black.transform.Translate(speed * -1, 0, 0);
			}
			if (gameObject.name == "white") {
				white.transform.Translate(speed, 0, 0);
				black.transform.Translate(speed, 0, 0);
			}
		}

		if (gameOver == true) {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("blackWin") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f || anim.GetCurrentAnimatorStateInfo(0).IsName("whiteWin") &&
					anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f ) {
						Application.LoadLevel("mainMenu");
			}
		}
	}

	public void checkWin () {

	}
}
