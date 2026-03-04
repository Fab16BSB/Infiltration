using UnityEngine;
using System.Collections;

public class DemasqueObjet : MonoBehaviour {

    public GameObject obj;
    public int lumiere;
    public Material materiel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            obj.transform.GetChild(0).GetComponent<Light>().range = lumiere;
            obj.transform.GetChild(1).GetComponent<TextMesh>().characterSize = 1;
            obj.transform.GetChild(2).GetComponent<Renderer>().material = materiel;
        }

    }
}
