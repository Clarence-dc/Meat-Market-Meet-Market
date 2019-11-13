using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Guard : MonoBehaviour
{
    public GameObject player;

    public float timeLeft = 0;
    public Text startText; // used for showing countdown from 3, 2, 1 

    private NavMeshAgent navmesh;

    // Start is called before the first frame update
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft == 0)
        {
            navmesh.destination = player.transform.position;
            navmesh.speed = 7;
        }
        else
        {
            navmesh.speed = 0;
        }
        timeLeft = timeLeft - Time.deltaTime;
        timeLeft=Mathf.Clamp(timeLeft, 0, 3);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<QuisController>()!=null)
        {
            timeLeft = 3.0f;
            Destroy(collision.gameObject);

        }

    }
}

