using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class QuisController : MonoBehaviour
{ 
    private NavMeshAgent _agent;
    [SerializeField] public GameObject Enemy;
    public float EnemyDistanceRun = 145.0f;
    

    float duration;
    // Start is called before the first frame update
    void Start()
    {
        duration = 5.0f;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy = GameObject.Find("Guard Sphere");
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);
        //Debug.Log("Distance: " + distance);

        // Run away from enemy
        if (distance < EnemyDistanceRun)
        {
            //Vector player to me
            Vector3 dirToEnemy = transform.position - Enemy.transform.position;
            Vector3 newPos = transform.position - dirToEnemy;
            _agent.SetDestination(newPos);
        }
        duration = duration - Time.deltaTime;
        if (duration < 0)
        {
            Destroy(gameObject);
        }
        {

        }
    }
}
