using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float cameraSpeed = 0f;

	void Update () {
		transform.Translate (cameraSpeed*Time.deltaTime, 0, 0);


	}
}
