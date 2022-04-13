using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NPC3Behaviour : MonoBehaviour
{
    Animator animator;
    NavMeshAgent theAgent;
    private bool ismoving;
    public GameObject destination;

    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        ismoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ismoving == true)
        {
           animator.SetBool("isMoving", true);

        }
        else
        {
           animator.SetBool("isMoving", false);
        }
        theAgent.SetDestination(destination.transform.position);

    }
}
