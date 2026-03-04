using UnityEngine;
using System.Collections;

public class WakeUp : MonoBehaviour {

	private GameObject player;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			AudioSource[] sources = enemy.GetComponents<AudioSource>();
			foreach (AudioSource s in sources)
				s.Stop();
			enemy.GetComponent<Sleeping>().enabled = false;
		}
	}
}
