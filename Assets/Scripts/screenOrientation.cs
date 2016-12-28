using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenOrientation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	// Update is called once per frame
	void Update () {
		Screen.orientation = ScreenOrientation.Portrait;
	}
}
