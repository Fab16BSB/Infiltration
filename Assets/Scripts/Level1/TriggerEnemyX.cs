using UnityEngine;
using System.Collections;

public class TriggerEnemyX : MonoBehaviour {

	// Use this for initialization
	private GameObject enemyX;
	private GameObject player;

	void Start () {
		enemyX = GameObject.Find("EnemyX");
		enemyX.SetActive(false);
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player) {
			enemyX.SetActive(true);
		}
	
	}
}
