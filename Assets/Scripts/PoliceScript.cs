using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceScript : MonoBehaviour
{
    public float fieldofViewAngle = 180f;
    public bool playerInSight;
    public Vector3 personalLastSighting;

    private NavMeshAgent agent;
    private SphereCollider col;


    private GameObject player;
    private Vector3 previousSighting;

    private Shopper1Control routeControl;
    public float timeLeft = 0;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();

        player = GameObject.Find("Player");
        routeControl = GetComponent<Shopper1Control>();

    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayer();
        if (playerInSight)
        {
            agent.SetDestination(player.transform.position);
            routeControl.enabled = false;
        }
        else
        {
            routeControl.enabled = true;
        }

        if (timeLeft == 0)
        {
          
            agent.speed = 7;
        }
        else
        {
            agent.speed = 0;
        }
        timeLeft = timeLeft - Time.deltaTime;
        timeLeft = Mathf.Clamp(timeLeft, 0, 3);
    }
    private void CheckPlayer()
    {
        //Debug.Log("OnTriggerStay");
        
            playerInSight = false;
            //Debug.Log("PlayerStay");
            Vector3 direction = player.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if (angle < fieldofViewAngle * 0.5f)

            {
                //Debug.Log("PlayerInFieldOfView");
                RaycastHit hit;
                if (Physics.Raycast(transform.position , direction.normalized, out hit, col.radius))
                {
                //Debug.Log("Hit "+hit.collider.gameObject.name);
                    if (hit.collider.gameObject == player)
                    {
                        //Debug.Log("PlayerSpotted");
                        if (player.GetComponent<PlayerController>().hasMeat == true)
                        {
                            playerInSight = true;
                        }
                    }
                }
            }
        
    }

     void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Crash"+collision.gameObject.name);
        if (collision.gameObject.GetComponent<QuisController>() != null)
        {
            timeLeft = 3.0f;
            Destroy(collision.gameObject);

        }

    }

}