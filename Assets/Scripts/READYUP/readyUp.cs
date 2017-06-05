using UnityEngine;
using System.Collections;

public class readyUp : MonoBehaviour {

	public bool readyw1;
	public bool readyw2;
	public bool readyb1;
	public bool readyb2;
	public Animator anim;

	public void Update () {
		anim = GameObject.Find("Canvas").GetComponent<Animator>();
		readyw1 = GameObject.Find("fingerPrints/wPrintL").GetComponent<askReadyUp>().ready;
		readyw2 = GameObject.Find("fingerPrints/wPrintR").GetComponent<askReadyUp>().ready;
		readyb1 = GameObject.Find("fingerPrints/bPrintL").GetComponent<askReadyUp>().ready;
		readyb2 = GameObject.Find("fingerPrints/bPrintR").GetComponent<askReadyUp>().ready;



		if (readyw1 == true && readyw2 == true && readyb1 == true && readyb2 == true) {
			anim.SetBool("ready", true);
			//counterAnim.SetTrigger("allIn");
			if (anim.GetCurrentAnimatorStateInfo(0).IsName("outReadyUp") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) {
				if (GameObject.Find("/constant") != null) {
					if (GameObject.Find("/constant").GetComponent<gameMode>().game == 1) {
						Application.LoadLevel("TAPTAP");
					} else if (GameObject.Find("/constant").GetComponent<gameMode>().game == 2) {
						Application.LoadLevel("TOW");
					} else if (GameObject.Find("/constant").GetComponent<gameMode>().game == 0 || GameObject.Find("/constant").GetComponent<gameMode>().game == null) {
							Application.LoadLevel("TAPTAP");
					}
				} else {
						Application.LoadLevel("TAPTAP");
					}
				}
			}
		}
	}
