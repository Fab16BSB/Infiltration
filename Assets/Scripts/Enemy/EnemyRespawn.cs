using UnityEngine;
using System.Collections;

public class EnemyRespawn : MonoBehaviour {

		GameObject player;
		Vector3 respawn;
		
	void Start () {
		player = GameObject.Find("Player");
		respawn = new Vector3(-30.8f,0.63f,-57.8f);
		
	}
	

	void Update () {
		
		if(player.GetComponent<CharacterHealth>().immunity && player.GetComponent<CharacterHealth>().respawnPoint == respawn){
			Application.LoadLevel("Level1");
		}
	}
}
