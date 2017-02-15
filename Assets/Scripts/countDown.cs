using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class countDown : MonoBehaviour {

	public float fromNum;
	public Animator anim;
	public GameObject one, two , three;

	void Awake () {
			anim = GetComponent<Animator>();
			one = GameObject.Find("counter/one");
			two = GameObject.Find("counter/two");
			three = GameObject.Find("counter/three");
	}

	void Update () {
		fromNum -= Time.deltaTime;
		int currentNum = (int)fromNum;
		anim.SetInteger("countNum", currentNum);
		if ( currentNum <= 0 ) {
				Destroy(one); Destroy(two); Destroy(three);
				gameObject.GetComponent<Text>().text = "";
		} else {
			string output = currentNum.ToString();
			gameObject.GetComponent<Text>().text = output;
		}
	}
}
