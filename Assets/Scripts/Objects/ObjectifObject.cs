using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectifObject : MonoBehaviour {

	private GameObject player;
	private Objectifs objectif;
	private GameObject env;
	private bool firstTime = true;
	public Text information;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		env = GameObject.Find("Environement");
		objectif = env.GetComponent<Objectifs>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (firstTime == true && other.gameObject == player) {
			objectif.displayInformation(information);
			firstTime = false;
		}
	}
}
