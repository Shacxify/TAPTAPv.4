using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towRules : MonoBehaviour {

	public GameObject white, black, sides;
	public float speed;
	public bool gameOver;
	public string winner;
	// Use this for initialization
	void Start () {
		white = GameObject.Find("Canvas/sides/white");
		black = GameObject.Find("Canvas/sides/black");
		sides = GameObject.Find("Canvas/sides");
	}

	void Update () {
		//checkWin();
	}

	public void toMove() {
		if (gameOver != true) {
			if (gameObject.name == "black") {
				sides.transform.Translate(new Vector2(speed * -1,0));
				//white.transform.Translate(new Vector2((speed * -1),0));
				//black.transform.Translate(new Vector2((speed * -1),0));
			}
			if (gameObject.name == "white") {
				sides.transform.Translate(new Vector2(speed,0));
				//black.transform.Translate(new Vector2(speed,0));
				//white.transform.Translate(new Vector2(speed,0));
			}
		}
	}

	public void checkWin () {
		if (sides.transform.position.x > 8.6) {
			winner = "white";
			gameOver = true;
		}
		if (sides.transform.position.x < -8.6) {
			winner = "black";
			gameOver = true;
		}
		if (gameOver == true) {
			Debug.Log("The winner is " + winner);
		}
	}
}
