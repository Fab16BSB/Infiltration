using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour
{
    public float fieldOfViewAngle = 120f;           // Number of degrees, centred on forward, for the enemy see.
    public bool playerInSight;                      // Whether or not the player is currently sighted.
    public bool playerHeared;
    public Vector3 personalLastSighting;            // Last place this enemy spotted the player.

    private NavMeshAgent nav;                       // Reference to the NavMeshAgent component.
    private SphereCollider col;                     // Reference to the sphere collider trigger component.
    private LastPlayerSighting lastPlayerSighting;  // Reference to last global sighting of the player.
    private GameObject player;                      // Reference to the player.
    private Vector3 previousSighting;               // Where the player was sighted last frame.
    private Sleeping sleeping;

    private EnemyLabel label;

    private float soundLimit;

    void Awake ()
    {
    	label = GetComponent<EnemyLabel>();
        nav = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();
		player = GameObject.Find("Player");
        lastPlayerSighting = player.GetComponent<LastPlayerSighting>();
       
        personalLastSighting = lastPlayerSighting.resetPosition;
        previousSighting = lastPlayerSighting.resetPosition;

        sleeping = GetComponent<Sleeping>();

        soundLimit = 0.7f;
    }
    
    
    void Update ()
    {
        // If the last global sighting of the player has changed...
        if(lastPlayerSighting.position != previousSighting)
            // ... then update the personal sighting to be the same as the global sighting.
            personalLastSighting = lastPlayerSighting.position;
        
        // Set the previous sighting to the be the sighting from this frame.
        previousSighting = lastPlayerSighting.position;
    }

    void OnTriggerStay (Collider other)
    {
        // If the player has entered the trigger sphere...
        if(other.gameObject == player)
        {
            // By default the player is not in sight.
            playerInSight = false;
            playerHeared = false;
            
            // Create a vector from the enemy to the player and store the angle between it and forward.
            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);
            
            // If the angle between forward and where the player is, is less than half the angle of view...
            if(angle < fieldOfViewAngle * 0.5f)
            {
                RaycastHit hit;
                
                // ... and if a raycast towards the player hits something...
                if(Physics.Raycast(transform.position, direction.normalized, out hit, col.radius))
                {
                    // ... and if the raycast hits the player...
		    	if(hit.collider.gameObject == player && !player.GetComponent<Rigidbody>().isKinematic)
                    {
                    	if (!GetComponent<AudioSource>().isPlaying && (sleeping==null || !sleeping.enabled))
                    		GetComponent<AudioSource>().Play();
                        // ... the player is in sight.
                        playerInSight = true;
						label.exclamation();

						personalLastSighting = player.transform.position;
                        // Set the last global sighting is the players current position.
                        //lastPlayerSighting.position = player.transform.position;
                    }
                }
            }

            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (player.GetComponent<CharacterSound>().dB / distance >= this.soundLimit || playerInSight) 
            {
            	playerHeared = true;
		if(CalculatePathLength(player.transform.position) <= col.radius) {
			personalLastSighting = player.transform.position;
			if (!playerInSight) 
			{
				label.interrogation();
			}	
		}	
            }
        }
    }
    
    
    void OnTriggerExit (Collider other)
    {
        // If the player leaves the trigger zone...
        if(other.gameObject == player) 
        {
	    // ... the player is not in sight.
            playerInSight = false;
            playerHeared = false;
        }
            
    }
    
    
    float CalculatePathLength (Vector3 targetPosition)
    {
        // Create a path and set it based on a target position.
        NavMeshPath path = new NavMeshPath();
        if(nav.enabled)
            nav.CalculatePath(targetPosition, path);
        
        // Create an array of points which is the length of the number of corners in the path + 2.
        Vector3[] allWayPoints = new Vector3[path.corners.Length + 2];
        
        // The first point is the enemy's position.
        allWayPoints[0] = transform.position;
        
        // The last point is the target position.
        allWayPoints[allWayPoints.Length - 1] = targetPosition;
        
        // The points inbetween are the corners of the path.
        for(int i = 0; i < path.corners.Length; i++)
        {
            allWayPoints[i + 1] = path.corners[i];
        }
        
        // Create a float to store the path length that is by default 0.
        float pathLength = 0;
        
        // Increment the path length by an amount equal to the distance between each waypoint and the next.
        for(int i = 0; i < allWayPoints.Length - 1; i++)
        {
            pathLength += Vector3.Distance(allWayPoints[i], allWayPoints[i + 1]);
        }
        
        return pathLength;
    }
}