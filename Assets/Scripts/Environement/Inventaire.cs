using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour {

	public Sprite map;
	public Sprite usb;

	private ArrayList inventaire;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		inventaire = GameObject.Find("Player").GetComponent<TakeObject>().inventaire;

		if(inventaire.Contains(GameObject.Find("Map"))){
            GameObject.Find("Image").GetComponent<Image>().sprite = map;
		}

		if(inventaire.Contains(GameObject.Find("USBKey"))){
            GameObject.Find("Image2").GetComponent<Image>().sprite = usb;
        }
	}
}
