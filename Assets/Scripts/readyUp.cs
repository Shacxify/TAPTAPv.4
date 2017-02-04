using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readyUp : MonoBehaviour {

	public GameObject wFL, wFR, bFL, bFR;
	public int totalClicks;
	public string chosenGM;
	public bool clickedWL = false, clickedWR = false,
							clickedBL = false, clickedBR = false;


	void Start () {
		wFL = GameObject.Find("Canvas/fingerPrints/wPrintL");
		wFR = GameObject.Find("Canvas/fingerPrints/wPrintR");
		bFL = GameObject.Find("Canvas/fingerPrints/bPrintL");
		bFR = GameObject.Find("Canvas/fingerPrints/bPrintR");
	}

	public void onClick () {

	}

	void Update () {
		if (totalClicks != 4) {
			if (clickedWL == true) {
				totalClicks =+ 1;
			} else if (clickedWR == true) {
				totalClicks =+ 1;
			} else if (clickedBL == true) {
				totalClicks =+ 1;
			} else if (clickedBR == true) {
				totalClicks =+ 1;
			}
		}

		if (totalClicks == 4) {
			Application.LoadLevel(chosenGM);
		}
	}
}
