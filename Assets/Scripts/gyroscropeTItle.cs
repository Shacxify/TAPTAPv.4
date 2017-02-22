using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscropeTitle : MonoBehaviour {

	public Gyroscope gyro;
	public GameObject bothSides;
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GameObject.Find("bg").GetComponent<Animator>();
		bothSides = GameObject.Find("bg/both");
		if (SystemInfo.supportsGyroscope) {
				gyro = Input.gyro;
    		gyro.enabled = true;
    }
	}

	// Update is called once per frame
	void Update () {
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("idleStart")
				&& anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.1f) {
			bothSides.transform.rotation = Quaternion.Euler(0, 0, /*gyro.attitude.z*/ 90);
		}
		//Debug.Log(gyro.attitude);
	}
}
