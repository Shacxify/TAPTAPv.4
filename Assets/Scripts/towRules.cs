using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towRules : MonoBehaviour {

	public GameObject white, black, sides, counter;
	public float speed;
	public bool gameOver, hasBegun;
	public string winner;
	public Animator anim;
	// Use this for initialization
	void Start () {
		white = GameObject.Find("Canvas/sides/white");
		black = GameObject.Find("Canvas/sides/black");
		sides = GameObject.Find("Canvas/sides");
		counter = GameObject.Find("Canvas/counter");
		anim = GameObject.Find("Canvas").GetComponent<Animator>();
	}

	void Update () {
		hasBegun = counter.GetComponent<countDown>().hasStarted;
		checkWin();
	}

	public void toMove() {
		if (gameOver == false && hasBegun == true) {
			if (gameObject.name == "black") {
				sides.transform.Translate(new Vector2(speed * -1,0));
				Debug.Log(sides.transform.position.x);
			}
			if (gameObject.name == "white") {
				sides.transform.Translate(new Vector2(speed,0));
			}
		}

		if (gameOver == true && hasBegun == true) {
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("blackWin") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f || anim.GetCurrentAnimatorStateInfo(0).IsName("whiteWin") &&
					anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f ) {
						Application.LoadLevel("mainMenu");
			}
		}
	}

	public void checkWin () {
		if (sides.transform.position.x > 9) {
			winner = "white";
			gameOver = true;
			anim.SetInteger("winner", 1);
		}
		if (sides.transform.position.x < -9) {
			winner = "black";
			gameOver = true;
			anim.SetInteger("winner", 2);
		}
		if (gameOver == true) {
			Debug.Log("The winner is " + winner);
		}
	}
}
