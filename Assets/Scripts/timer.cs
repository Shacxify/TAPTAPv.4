using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour {

	public float timeLeft;
	public Text counter;

	// Use this for initialization
	void Start () {
		counter = GameObject.Find("Canvas/counter").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		counter.text = ((int)timeLeft).ToString();
		if (timeLeft <= 0) {
			Destroy(counter);
		}
	}
}
