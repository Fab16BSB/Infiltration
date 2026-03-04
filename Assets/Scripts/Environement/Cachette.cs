using UnityEngine;
using System.Collections;

public class Cachette : MonoBehaviour {

	private GameObject[] IA;
	public bool cacher = false;
	public bool onTrigger = false;
	private GameObject player;
    private TextMesh label;
	private static bool firstTime = true;
	private Objectifs objectif;

	void Start () {
	    objectif = GameObject.Find("Environement").GetComponent<Objectifs>();
	    player = GameObject.Find("Player");
        IA = GameObject.FindGameObjectsWithTag("Enemy");
	    label = transform.FindChild("Cachette Label").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (onTrigger && !cacher && Input.GetKeyDown(KeyCode.Space) && !player.GetComponent<PlayerController>().vu && !player.GetComponent<PlayerController>().entendu) {
		if (firstTime)
        	{
			objectif.HelpTrashCan();
			firstTime = false;
        	}
        	player.GetComponent<PlayerController>().run = false;
		player.GetComponent<PlayerController>().walk = false;
                cacher=true;
				 GetComponent<AudioSource>().Play();
                player.GetComponent<PlayerController>().disappear();
                player.GetComponent<PlayerController>().fixMovement();
            }
	    else if (Input.GetKeyDown(KeyCode.Space) && cacher) {
				GetComponent<AudioSource>().Stop();
                cacher=false;
                player.GetComponent<PlayerController>().reappear();
                player.GetComponent<PlayerController>().unfixMovement();
            }
	}

	void OnTriggerEnter(Collider other)
        {
        	if (other.gameObject.name == "Player")
	        {
			onTrigger = true;
	                transform.GetChild(0).GetComponent<TextMesh>().characterSize = 1;
            	}
        }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player" && cacher)
    	{
    		//player.GetComponent<LastPlayerSighting>().position = player.GetComponent<LastPlayerSighting>().resetPosition;
	        foreach (GameObject ia in IA) 
	        {
		    player.GetComponent<PlayerController>().vu = false;
		    player.GetComponent<PlayerController>().entendu = false;
	            ia.GetComponent<EnemySight>().playerInSight = false;
		    ia.GetComponent<EnemySight>().playerHeared = false;
	            //ia.GetComponent<EnemySight>().personalLastSighting = player.GetComponent<LastPlayerSighting>().resetPosition;
	        }
            	player.GetComponent<Rigidbody>().isKinematic = true;
    	}
		
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
           onTrigger = false;
           label.characterSize = 0;
            player.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
