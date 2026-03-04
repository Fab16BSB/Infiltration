using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class Quitter : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick (PointerEventData eventData){
		Application.Quit();
	}
}
