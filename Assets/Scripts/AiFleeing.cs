using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiFleeing : MonoBehaviour
{

    public GameObject npc;
    private NavMeshAgent _agent;
    public GameObject Player;
    public float EnemyDistanceRun = 4.0f;
    public Transform[] patrolPoints;
    private int currentPointIdex = 0;
    private bool patrol = true;
    public static bool hasFinishedQues1 = false;

    public QuestManager qm;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        MoveToNextpatrolPoint();
        ChickenCode();
    }
    void Update()
    {
        if (_agent.remainingDistance < 0.5f && !_agent.pathPending && patrol == true)
        {
            MoveToNextpatrolPoint();
        }

    }



    public void MoveToNextpatrolPoint()
    {
        if (patrolPoints.Length > 0)
        {
            _agent.destination = patrolPoints[currentPointIdex].position;
            currentPointIdex++;
            currentPointIdex %= patrolPoints.Length;
        }

    }
    // Update is called once per frame


    void ChickenCode()
    {


        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < EnemyDistanceRun)
        {
            patrol = false;
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            _agent.SetDestination(newPos);

        }
    }


}
