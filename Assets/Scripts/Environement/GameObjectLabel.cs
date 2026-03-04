using UnityEngine;
using System.Collections;

public class GameObjectLabel : MonoBehaviour {

	public TextMesh label;

	public string normalString;
	public string forbiddenString;

	public bool isForbidden = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
        {
	        if (other.gameObject.name == "Player")
		{
			if (isForbidden) 
			{
				label.color = new Color32(169, 45, 45, 255);
				label.text = forbiddenString;
			}
			else
			{
				label.color = new Color32(255, 255, 255, 255);
				label.text = normalString;
			}
			label.characterSize = 1;
	        }
        }

	void OnTriggerExit(Collider other)
        {
	        if (other.gameObject.name == "Player")
		{
			label.GetComponent<TextMesh>().characterSize = 0;
	        }
        }
}
