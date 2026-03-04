using UnityEngine;
using System.Collections;

public class RotateObjects : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {

		this.speed = 7f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime * this.speed);
	}
}
