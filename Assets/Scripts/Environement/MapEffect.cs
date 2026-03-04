using UnityEngine;
using System.Collections;

public class MapEffect : MonoBehaviour {

    private GameObject[] objet;
    private GameObject life;
    public int lumiere=15;

    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {


    }


    void OnCollisionEnter(Collision collider)
    {

        if (collider.gameObject.name == "Player")
        {
            objet = GameObject.FindGameObjectsWithTag("Objet");
            if (objet != null) 
            {
		for (int i = 0; i<objet.Length;i++)
            	{
               	 objet[i].transform.GetChild(0).GetComponent<Light>().range = lumiere;
                	objet[i].transform.GetChild(1).GetComponent<TextMesh>().characterSize = 1;
           	 }

            	life = GameObject.FindGameObjectWithTag("Life");
            	if (life != null)
            	{
			life.transform.GetChild(0).GetComponent<Light>().range = lumiere;
            		life.transform.GetChild(1).GetComponent<TextMesh>().characterSize = 1;
            	}
            }
        }
    }
}
