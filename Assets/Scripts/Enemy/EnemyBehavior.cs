using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{
    public float patrolSpeed;
    public float chaseSpeed;
    public float chaseWaitTime;
    public float patrolWaitTime;
    public Transform[] patrolWayPoints;         

    private EnemySight enemySight;                      
    private NavMeshAgent nav;                              
    private Transform player;                            
    private LastPlayerSighting lastPlayerSighting;          
    private float chaseTimer;                          
    private float patrolTimer;                            
    private int wayPointIndex; 

    // Lumiere
    private Color patrolColor;
    private Color alertColor;  

    private EnemyLabel label;          
        
    void Awake ()
    {
		label = GetComponent<EnemyLabel>();

		patrolSpeed = 5f;                        
    	chaseSpeed = 12f;                     
    	chaseWaitTime = 1f;                   
   		patrolWaitTime = 1f;             
        enemySight = GetComponent<EnemySight>();
        nav = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        lastPlayerSighting = player.GetComponent<LastPlayerSighting>();

		patrolColor = new Color32(245, 232, 54, 255);
		alertColor = new Color32(245, 54, 54, 100);
    }

    void Update ()
    {
        if(enemySight.personalLastSighting != lastPlayerSighting.resetPosition)
        {
			transform.GetChild(0).GetComponent<Light>().color = this.alertColor;
			Chasing();
        }
        else
        {
			GetComponent<AudioSource>().Stop();
			Patrolling();
			transform.GetChild(0).GetComponent<Light>().color = this.patrolColor;
        }   
    }
    
    void Chasing ()
    {
        // Create a vector from the enemy to the last sighting of the player.
        Vector3 sightingDeltaPos = enemySight.personalLastSighting - transform.position;
        
        // If the the last personal sighting of the player is not close...
        if(sightingDeltaPos.sqrMagnitude > 4f)
            // ... set the destination for the NavMeshAgent to the last personal sighting of the player.
            nav.destination = enemySight.personalLastSighting;
        
        // Set the appropriate speed for the NavMeshAgent.
        nav.speed = chaseSpeed;
        
        // If near the last personal sighting...
        if(nav.remainingDistance < nav.stoppingDistance)
        {
            // ... increment the timer.
            chaseTimer += Time.deltaTime;
            
            // If the timer exceeds the wait time...
            if(chaseTimer >= chaseWaitTime)
            {
                // ... reset last global sighting, the last personal sighting and the timer.
                lastPlayerSighting.position = lastPlayerSighting.resetPosition;
                enemySight.personalLastSighting = lastPlayerSighting.resetPosition;
                chaseTimer = 0f;
            }
        }
        else
        {
	    // If not near the last sighting personal sighting of the player, reset the timer.
            chaseTimer = 0f;
        }
            
    }

    
    void Patrolling ()
    {
	label.none();
        // Set an appropriate speed for the NavMeshAgent.
        nav.speed = patrolSpeed;
        
        // If near the next waypoint or there is no destination...
        if(nav.destination == lastPlayerSighting.resetPosition || nav.remainingDistance < nav.stoppingDistance)
        {
            // ... increment the timer.
            patrolTimer += Time.deltaTime;
            
            // If the timer exceeds the wait time...
            if(patrolTimer >= patrolWaitTime)
            {
                // ... increment the wayPointIndex.
                if(wayPointIndex == patrolWayPoints.Length - 1)
                    wayPointIndex = 0;
                else
                    wayPointIndex++;
                
                // Reset the timer.
                patrolTimer = 0;
            }
        }
        else
            // If not near a destination, reset the timer.
            patrolTimer = 0;
        
        // Set the destination to the patrolWayPoint.
        nav.destination = patrolWayPoints[wayPointIndex].position;
    }
}
