using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour
{
	private bool win;

	void Start () 
	{
		win = false;
	}
	
	void Update () 
	{
		
	}

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.name == "Computer")
            Application.LoadLevel("Victory");
        }
	

}

