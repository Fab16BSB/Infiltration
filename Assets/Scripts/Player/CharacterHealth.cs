using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour 
{
	public int health;
	public int maxHealth;
	public bool dead;
	public bool immunity;
	public bool addLifeWait;
	public Vector3 respawnPoint;
	private float timer;
	private float immunityTime;
	private float addLifeDelay = 1f;
	private GameObject labelImmunity;
	private GameObject env;
	private AudioSource[] audioSources;

	// Use this for initialization
	void Start () 
	{
	    this.immunityTime = 5f;
	    this.timer = 0f;
	    this.maxHealth = 2;
	    this.health = this.maxHealth;
	    this.dead = false;
	    this.immunity = false;
	    this.addLifeWait = false;
        this.respawnPoint = transform.position;
        this.labelImmunity = GameObject.Find("ImmunityLabel");
        this.env = GameObject.Find("Environement");
		this.audioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if (health <= 0)
	    {
	    	this.dead = true;
	    }
	    if (this.dead)
	    {
	    	this.deathManagement();
	    }
	    if (this.immunity)
	    {
			foreach (AudioSource a in audioSources) {
				a.Stop();
			}
			timer += Time.deltaTime;
			if (timer >= this.immunityTime) {
				this.immunity = false;
				this.labelImmunity.GetComponent<Text>().text = "";
			}  
	    }
	    if (this.addLifeWait)
	    {
		timer += Time.deltaTime;
		if (timer >= this.addLifeDelay)
		     this.addLifeWait = false;
	    }
	}

	public float getTimer() {
		return this.timer;
	}

	public void lost1Health()
	{
		this.env.GetComponent<PersistentObject>().reset();
		if (!this.immunity)
		{
			timer = 0f;
			this.immunity = true;
			this.labelImmunity.GetComponent<Text>().text = "Immunity";
			lostHealth(1);
			transform.position = this.respawnPoint;
		}
	}

	public void lostHealth(int health)
	{
		if (this.health-health <= 0)
		{
			this.health = 0;
			this.dead = true;
		}
		else
		{
			this.health -= health;
		}
	}

	public void addHealth(int health)
	{
		timer = 0;
		if (!addLifeWait) 
		{
			this.addLifeWait = true;
			this.health += health;
		}	
	}

	public void deathManagement()
	{
		//SceneManager.LoadScene("GameOver");
		Application.LoadLevel("GameOver");
	}
}
