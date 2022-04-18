using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_master : MonoBehaviour
{

    public GameObject Player;
    public float Distance;

    public bool isAngered;

    public NavMeshAgent _agent;

    void Start()
    {

    }

    void update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if(Distance <=5)
        {
            isAngered = true;
        }
        if(Distance > 5f)
        {
            isAngered = false;
        }

        if(isAngered)
        {
            _agent.SetDestination(Player.transform.position);
        }
        if(!isAngered)
        {
            _agent.isStopped = true;
        }
    }
}