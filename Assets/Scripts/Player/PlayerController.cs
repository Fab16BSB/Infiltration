using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float walkSpeed;
    public float runSpeed;
    public float sneakSpeed;

    public bool walk;
    public bool sneak;
    public bool run;

    public bool vu = false;
    public bool entendu = false;
    private GameObject[] IA;

    private bool fixedMovement;

    private CharacterController controller;
	 
    public AudioSource sonMarche;
    public AudioSource sonCourse;

    // Use this for initialization
    void Start()
    {

		IA = GameObject.FindGameObjectsWithTag("Enemy");
		this.controller = GetComponent<CharacterController>();
    	this.sneak = false;
    	this.run = false;
    	this.walk = false;

    	this.walkSpeed = 8;
    	this.runSpeed = 16;
    	this.sneakSpeed = 4;

        this.fixedMovement = false;		
    }

    void Update() 
    {

		if (estEntendu())
	    		this.entendu = true;
	    else
	    		this.entendu = false;

	    if (estVu())
	    		this.vu = true;
	    else
	    		this.vu = false;
	    		
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		bool up = false;
		bool down = false;
		bool left = false;
		bool right = false;

		if (!fixedMovement)
		{
			up = (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow));
	       		down = (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow));
	        	left = (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow));
	        	right = (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow));

		}

        // Rotation selon sens de direction
        if (up)
        {
	       transform.forward = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        }
        else if (down)
        {
	       transform.forward = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        }
        else if (left)
        {
	       transform.forward = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        }
        else if (right)
        {
	       transform.forward = Vector3.Normalize(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
        }	

    	// Gestion de l'état du joueur   
    	if (!fixedMovement) 
    	{
		this.sneak = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
    		this.run = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
    		this.walk = up || down || left || right;
    	}

    	// Déplacement
    	Vector3 motion = input;
    	motion *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1)?.7f:1;
		
	if (this.run && this.walk && !this.sonCourse.isPlaying) {
		if (this.sonMarche.isPlaying)
			this.sonMarche.Stop();
		this.sonCourse.Play();
	}
	else if (this.walk && !this.sonMarche.isPlaying && !this.run){
		if (this.sonCourse.isPlaying)
			this.sonCourse.Stop();
		this.sonMarche.Play();
	}
	else if ((!run && !sneak && !walk) || sneak || (run && !walk)){
		this.sonCourse.Stop();
		this.sonMarche.Stop();
	}
		
		
		
    	if (this.run){
    	    motion *= this.runSpeed;
		}
    	else if (this.sneak){
    	    motion *= this.sneakSpeed;
		}
    	else{
    	    motion *= this.walkSpeed;
			
		}
    	motion += Vector3.up * -8;
		
		
        if (!this.fixedMovement)
    	   controller.Move(motion * Time.deltaTime);
		   
		   
		
		   
    }

    public void disappear()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;

        transform.Find("Head").GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Head").GetComponent<BoxCollider>().enabled = false;

        transform.Find("Arm1").GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Arm1").GetComponent<BoxCollider>().enabled = false;

        transform.Find("Arm2").GetComponent<MeshRenderer>().enabled = false;
        transform.Find("Arm2").GetComponent<BoxCollider>().enabled = false;

        transform.Find("PlayerLight").GetComponent<Light>().enabled = false;
       
    }

    public void reappear()
    {
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;

        transform.Find("Head").GetComponent<MeshRenderer>().enabled = true;
        transform.Find("Head").GetComponent<BoxCollider>().enabled = true;

        transform.Find("Arm1").GetComponent<MeshRenderer>().enabled = true;
        transform.Find("Arm1").GetComponent<BoxCollider>().enabled = true;

        transform.Find("Arm2").GetComponent<MeshRenderer>().enabled = true;
        transform.Find("Arm2").GetComponent<BoxCollider>().enabled = true;

       transform.Find("PlayerLight").GetComponent<Light>().enabled = true;

    }

    public void fixMovement()
    {
        this.fixedMovement = true;
    }

    public void unfixMovement()
    {
        this.fixedMovement = false;
    }

    public bool estVu()
    {
    	bool repere = false;
	foreach(GameObject ia in IA)
        {
            if (ia.GetComponent<EnemySight>().playerInSight)
            {
                repere = true;
                break;
            }
        }
        return repere;
    }

    public bool estEntendu()
    {
    	bool repere = false;
	foreach(GameObject ia in IA)
        {
            if (ia.GetComponent<EnemySight>().playerHeared)
            {
                repere = true;
                break;
            }
        }
        return repere;
    }
   
}

