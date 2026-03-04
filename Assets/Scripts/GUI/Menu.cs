using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
using UnityEngine.EventSystems; 

public class Menu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	private Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	}


	public void OnPointerEnter (PointerEventData eventData) {
		text.color = Color.black;
	}

	public void OnPointerExit(PointerEventData eventData) {
		text.color = Color.white; 
	}

}
