﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Shopper1Control : MonoBehaviour
{
    public AudioSource Bang;
    public AudioSource Bell;
    public AudioSource GetOut;
    public AudioSource Defeat;

    public void PlayBang()
    {
        GetOut.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetOut.Play();
    }

public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
