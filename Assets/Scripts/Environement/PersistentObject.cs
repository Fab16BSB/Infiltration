using UnityEngine;
using System.Collections;

public class PersistentObject : MonoBehaviour {

	public GameObject[] objets;
	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void reset() {
	
		foreach(GameObject obj in objets){
			obj.SetActive(true);
		}
	}
}
