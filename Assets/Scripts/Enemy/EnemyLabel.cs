using UnityEngine;
using System.Collections;

public class EnemyLabel : MonoBehaviour {

	private TextMesh label;

	// Use this for initialization
	void Start () {
		this.label = transform.FindChild("Label").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void exclamation() {
		label.color = new Color32(182, 17, 17, 255);
		label.text = "!";
	}

	public void interrogation() {
		label.color = new Color32(255, 255, 255, 255);
		label.text = "?";
	}

	public void endormi() {
		label.color = new Color32(255, 255, 255, 255);
		label.text = "Endormi...";
	}

	public void none() {
		label.text = "";
	}

}
