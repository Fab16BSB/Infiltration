 using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float smooth;
	public GameObject player;
	private Vector3 positionJoueur;
	public float hauteur;

	// Use this for initialization
	void Start () {
		positionJoueur = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		positionJoueur = player.transform.position;
		Vector3 goal = new Vector3(positionJoueur.x, hauteur, positionJoueur.z);
		transform.position = Vector3.Lerp(transform.position, goal, smooth);
	}
}
