using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ouverture : MonoBehaviour
{

    private ArrayList inventairePlayer;
    public GameObject item;
    public GameObject porte;
    private GameObjectLabel label;
    public GameObject doorTimerImage;
    private GameObject player;
    private bool inTrigger = false;

    private AudioSource crochetageSound;
    private AudioSource openDoorSound;

    private float timer = 0f;
    public float delayOpen = 4f;

    // Use this for initialization
    void Start()
    {
    	player = GameObject.Find("Player");
    	doorTimerImage = GameObject.Find("DoorTimer");
    	label = GetComponent<GameObjectLabel>();
    	crochetageSound = GameObject.Find("CrochetageSound").GetComponent<AudioSource>();
		openDoorSound = GameObject.Find("OpenDoorSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
	    foreach (GameObject obj in inventairePlayer)
            {
		if (obj.Equals(item))
		{
			doorTimerImage.GetComponent<Image>().fillAmount = timer/delayOpen;

			if (Input.GetKey(KeyCode.Space)) 
			{
				if (!crochetageSound.isPlaying)
					crochetageSound.Play();
				timer += Time.deltaTime;
			}
			else
			{
				crochetageSound.Stop();
				timer = 0f;
			}
			if (timer >= delayOpen)
			{
				timer = 0f;
				doorTimerImage.GetComponent<Image>().fillAmount = 0;
				crochetageSound.Stop();
				openDoorSound.Play();
				porte.SetActive(false);
				//Destroy(porte);
			}
		}
            }
        }
    }

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.name == "Player")
        {
            inventairePlayer = GameObject.Find("Player").GetComponent<TakeObject>().inventaire;

            inTrigger = true;

            foreach (GameObject obj in inventairePlayer)
            {
                if (obj.Equals(item))
                {
                    label.isForbidden = false;
                }
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
		if (collider.gameObject.name == "Player") 
		{
			crochetageSound.Stop();
			doorTimerImage.GetComponent<Image>().fillAmount = 0f;
			inTrigger = false;
		}
    }

    void OnCollisionEnter(Collision collider)
    {
		if(collider.gameObject.tag == "Enemy") {
			 openDoorSound.Play();
		     porte.GetComponent<MeshRenderer>().enabled=false;
		}
    }


    void OnCollisionExit(Collision collider)
    {
		if(collider.gameObject.tag == "Enemy") {
			porte.GetComponent<MeshRenderer>().enabled = true;
		}
    }
}
