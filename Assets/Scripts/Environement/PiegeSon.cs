using UnityEngine;
using System.Collections;

public class PiegeSon : MonoBehaviour {

    private bool sneak;
    public AudioClip piegeSound;
    private bool dejaJouer = false;
    private bool rotate = false;
    private float soundTimer;
    private float soundDuration;
    private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		soundTimer = 0.1f;
		soundDuration = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		if (rotate && transform.rotation.z <= 0)
			transform.Rotate(Vector3.back * Time.deltaTime * 200f);
		else
			rotate = false;

		if (dejaJouer && soundTimer < soundDuration) 
		{
			player.GetComponent<CharacterSound>().makeSound(30);
			soundTimer += Time.deltaTime;
		}
		else if (soundTimer >= soundDuration)
		{
			player.GetComponent<CharacterSound>().soundIsPlaying = false;
		}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            sneak = player.GetComponent<PlayerController>().sneak;

            if (other.gameObject.name == "Player" && !sneak && !dejaJouer)
            {
                GetComponent<AudioSource>().Play();
		player.GetComponent<CharacterSound>().soundIsPlaying = true;
                dejaJouer = true;
                rotate = true;
            }

        }
    }
}
