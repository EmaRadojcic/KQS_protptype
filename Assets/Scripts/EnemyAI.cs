using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour

{
    public static bool follow = false;
    private Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Update()
    {
        if(follow == true)
        {
            FollowPlayer();
        }
    }

    // Update is called once per frame
   
 


    void FollowPlayer()
    {

        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        //set the navmesh agent's desination equal to the main camera's position (our first person character)
        agent.destination = goal.position;
    }

    }
