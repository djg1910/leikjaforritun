using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_master : MonoBehaviour
{

    public GameObject Player;
    public float Distance; //finnur lengd frá player

    public bool isAngered; //gerir óvin reiðan og hann eltir þig

    public NavMeshAgent _agent; //lætur óvin geta elt þig

    void Start()
    {

    }

    void update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);  //finnur lengd frá player

        if(Distance <=5)
        {
            isAngered = true;  //gerir óvin reiðan
        }
        if(Distance > 5f)
        {
            isAngered = false;  //lætur óvin hætta að vera reiður
        }

        if(isAngered)
        {
            _agent.SetDestination(Player.transform.position);  //ef óvinur er reiður eltir hann player
        }
        if(!isAngered)
        {
            _agent.isStopped = true;  //ef hann er ekki reiður stoppar hann
        }
    }
}
