using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	public GameObject explosion;
	public Transform player;
	public string LevelToLoad;

	void OnTriggerEnter (Collider collider)
	{
		Destroy(gameObject);
		Instantiate (explosion, player.position, player.rotation);
	}
}
