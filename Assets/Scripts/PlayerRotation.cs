using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {


	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.Rotate (0, 0, -90);
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			transform.Rotate (0, 0, 90);
		}
	}
}
