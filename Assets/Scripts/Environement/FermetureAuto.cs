using UnityEngine;
using System.Collections;

public class FermetureAuto : MonoBehaviour
{
	public AudioClip sound;
    public GameObject objet;
    private bool firstPassage = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            objet.GetComponent<MeshRenderer>().enabled = true;
            objet.GetComponent<BoxCollider>().enabled = true;
            if (firstPassage) {
				GetComponent<AudioSource>().Play();
				firstPassage = false;
            }
        }
    }
}
