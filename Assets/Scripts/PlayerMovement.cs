using System.Collections;

using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 0.3f;

	public void Update ()
	{
		
		transform.Translate (speed*Time.deltaTime, 0, 0);

		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (0, -speed*Time.deltaTime, 0);
		} else
			transform.Translate (0,speed*Time.deltaTime, 0);


	}


	}

	

