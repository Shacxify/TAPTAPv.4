﻿using UnityEngine;
using System.Collections;

public class buttonDirection : MonoBehaviour {

	// Use this for initialization
	public void onClick () {
		if (gameObject.name == "settings") {
			Application.LoadLevel("settings");
		} else if (gameObject.name == "play") {
			Application.LoadLevel("mainMenu");
		}
	}
}
