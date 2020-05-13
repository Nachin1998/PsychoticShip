using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	public float maxRotation = 0f;
	float rotateWaitTime = 0f;
	float diagonalWaitTime = 0f;

	void Update () {
		transform.Rotate (0, 0, maxRotation*Time.deltaTime);

		if (rotateWaitTime > Random.Range(5,10)) {
			maxRotation = maxRotation * -1;
			rotateWaitTime = 0;
		}
		rotateWaitTime += UnityEngine.Time.deltaTime;
	}
}
