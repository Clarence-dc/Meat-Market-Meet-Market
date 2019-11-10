using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceScript : MonoBehaviour
{
    public float fieldofViewAngle = 110f;
    public bool playerInSight;
    public Vector3 personalLastSighting;

    private NavMeshAgent agent;
    private SphereCollider col;


    private GameObject player;
    private Vector3 previousSighting;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();

        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        if (playerInSight)
        {
            agent.SetDestination(player.transform.position);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
        if (other.gameObject == player)
        {
            playerInSight = false;
            Debug.Log("PlayerStay");
            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if (angle < fieldofViewAngle * 0.5f)

            {
                Debug.Log("PlayerInFieldOfView");
                RaycastHit hit;
                if (Physics.Raycast(transform.position , direction.normalized, out hit, col.radius))
                {
                    Debug.Log("Hit "+hit.collider.gameObject.name);
                    if (hit.collider.gameObject == player)
                    {
                        Debug.Log("PlayerSpotted");
                        playerInSight = true;
                    }
                }
            }
        }
    }

}