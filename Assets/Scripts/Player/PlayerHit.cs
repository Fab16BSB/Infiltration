using UnityEngine;
using System.Collections;

public class PlayerHit : MonoBehaviour 
{

	private CharacterHealth health;

	// Use this for initialization
	void Start () 
	{
		this.health = gameObject.GetComponent<CharacterHealth>();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.tag == "Enemy")
			this.health.lost1Health();
	}
}
