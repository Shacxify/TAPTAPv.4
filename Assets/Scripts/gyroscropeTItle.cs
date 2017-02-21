using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscropeTItle : MonoBehaviour {

	public Gyroscope gyro;
	public GameObject bg;

	// Use this for initialization
	void Start () {
		bg = GameObject.Find("bg/both");
		if (SystemInfo.supportsGyroscope) {
				gyro = Input.gyro;
    		gyro.enabled = true;
    }
	}

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(0, 0, Input.gyro.attitude.z);
		Debug.Log(Input.gyro.attitude);
	}
}
