using UnityEngine;
using System.Collections;

public class Sleeping : MonoBehaviour {

	private GameObject player; 
	private float soundLimit;
	private EnemySight enemySight;
	private EnemyBehavior enemyBehavior;
	private EnemyLabel label;
	private SphereCollider collider;
	private Sleeping sleeping;
	public AudioSource sleepingSound;

	// Use this for initialization
	void Start () {
		enemySight = GetComponent<EnemySight>();
		enemyBehavior = GetComponent<EnemyBehavior>();
		enemySight.enabled = false;
		enemyBehavior.enabled = false;
		player = GameObject.Find("Player");
		soundLimit = 1f;
		label = GetComponent<EnemyLabel>();
		transform.GetChild(0).GetComponent<Light>().color = new Color32(87, 28, 124, 255);
		collider = GetComponent<SphereCollider>();
		sleeping = GetComponent<Sleeping>();
	}

	// Update is called once per frame
	void Update () {
		if (!sleepingSound.isPlaying) {
			sleepingSound.Play();
		}
	}

	void OnTriggerStay(Collider other) {
	    if(other.gameObject == player)
        {
        	label.none();
		    float distance = Vector3.Distance(transform.position, player.transform.position);
	        if (player.GetComponent<CharacterSound>().dB / distance >= this.soundLimit) 
	        {
				transform.GetChild(0).GetComponent<Light>().enabled = true;
				sleepingSound.Stop();
				enemySight.enabled = true;
				enemyBehavior.enabled = true;
				collider.radius = 25;
				sleeping.enabled = false;
	        }
        }
	}
}
