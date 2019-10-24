using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopperControl : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] movesSpots;
    private int randomSpot;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, movesSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movesSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movesSpots[randomSpot].position) < 0.2f){
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, movesSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
            }
        }
    }

