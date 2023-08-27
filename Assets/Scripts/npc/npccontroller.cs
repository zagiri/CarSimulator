using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npccontroller : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator animator;
    
    public GameObject PATH;
    private Transform[] WayPoints;

    public float minDistance = 1;

    private int index = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        WayPoints = new Transform[PATH.transform.childCount];
        for (int i=0; i < WayPoints.Length; i++)
        {
            WayPoints[i] = PATH.transform.GetChild(i);
        }
    }

    void Update() 
    {
        roam();
    }
    void roam() 
    {
        if (Vector3.Distance(transform.position, WayPoints[index].position) < minDistance) 
        {
            //if (index >= 0 && index < WayPoints.Length) 
            if(index+1 < WayPoints.Length)
            {
                index += 1;
            }
            else
            { 
                index = 0; 
            }
        }
        agent.SetDestination(WayPoints[index].position);
        animator.SetFloat("vertical", !agent.isStopped ? 1 : 0);
    }
}
