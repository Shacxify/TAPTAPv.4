using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMode : MonoBehaviour {

	// 1 = TAPTAP; 2 = TOW;
	public int game = 0;

	/*public override void OnPointerDown( PointerEventData data )
		{
			Debug.Log( "OnPointerDown called." );
		}*/

	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
	}
}
