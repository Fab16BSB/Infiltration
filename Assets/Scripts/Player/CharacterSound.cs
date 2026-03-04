using UnityEngine;
using System.Collections;

public class CharacterSound : MonoBehaviour
{

    private const int noSoundDB = 0;
    private const int sneakDB = 1;
    private const int walkDB = 10;
    private const int runDB = 15;

    public int dB = 0;
    public bool soundIsPlaying = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool walk = gameObject.GetComponent<PlayerController>().walk;
		bool sneak = gameObject.GetComponent<PlayerController>().sneak;
		bool run = gameObject.GetComponent<PlayerController>().run;

        if (run && walk && !soundIsPlaying)
            this.dB = CharacterSound.runDB;
	else if (sneak && walk && !soundIsPlaying)
            this.dB = CharacterSound.sneakDB;
	else if (walk && !soundIsPlaying)
            this.dB = CharacterSound.walkDB;
        else if (!soundIsPlaying)
            this.dB = CharacterSound.noSoundDB;
    }

    public void makeSound(int dB)
    {
        this.dB = dB;
    }
}