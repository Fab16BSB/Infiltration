/*using UnityEngine;
using System.Collections;

public class ObjectLabel : MonoBehaviour {

	public string message;

	   
	void OnTriggerEnter(Collider other)
        {
 		if (other.gameObject.name == "Player")
       		 {
		GetComponent<TextMesh>().text = message;
	            GetComponent<TextMesh>().characterSize = 1;	
		}
	}
    


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
     
           GetComponent<TextMesh>().characterSize = 0;
        }
    }
}*/
