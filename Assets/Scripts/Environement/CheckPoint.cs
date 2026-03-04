using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

	private AudioSource[] audioSources;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "Player") {
			other.GetComponent<CharacterHealth>().respawnPoint = transform.position;
			GetComponent<CheckPoint>().enabled = false;
		}
	}
}
