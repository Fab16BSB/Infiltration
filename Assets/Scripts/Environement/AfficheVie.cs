using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class AfficheVie : MonoBehaviour {

	private GameObject player;
	public int vie;
	public Text text;

	// Use this for initialization
	void Start () {
		vie = 2;
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find("Player");
		vie = player.GetComponent<CharacterHealth>().health;
		text.text = "x" + vie;
	}
}
