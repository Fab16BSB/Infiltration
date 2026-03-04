using UnityEngine;
using System.Collections;
﻿using UnityEngine.UI;

public class AfficheSon : MonoBehaviour {

	public Text textSon;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        affichage(GameObject.Find("Player").GetComponent<CharacterSound>().dB);    
	}

	public void affichage(int volume){
		string mess = " test";

		if(volume < 10){
			mess = "- -";
		}	
		else if(volume < 15){
			mess = "XX";
		}
		else {
			mess = "XXX";
		}
		//textSon.text = "Bruit  : " + volume + " dB";//sous form de nombre
		textSon.text = "Bruit  : " + mess;//sous forme de croix 
	}
}
