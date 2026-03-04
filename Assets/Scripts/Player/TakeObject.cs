using UnityEngine;
using System.Collections;

public class TakeObject : MonoBehaviour
{
    public ArrayList inventaire;
    public AudioSource takeSound;

    // Use this for initialization
    void Start()
    {
        inventaire = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Objet")
        {
			takeSound.Play();
            GameObject obj = collider.gameObject;
            inventaire.Add(obj);
            //obj.SetActive(false);
            obj.transform.position= new Vector3(500, 500, 500);
        }

        if (collider.gameObject.tag == "Life" && !this.GetComponent<CharacterHealth>().immunity)
        {
			takeSound.Play();
            GameObject obj = collider.gameObject;
	    	obj.SetActive(false);
            //obj.transform.position = new Vector3(500, 500, 500);
            GameObject.Find("Player").GetComponent<CharacterHealth>().addHealth(1);
        }
    }
}
