using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems; 
//using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void OnPointerClick (PointerEventData eventData){
		//SceneManager.LoadScene("Level0");
		Application.LoadLevel("Scenario");

	}
}
