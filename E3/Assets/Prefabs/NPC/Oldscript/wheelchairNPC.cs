using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class wheelchairNPC : MonoBehaviour
{
    public GameObject destination;
    Animator animator;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject timeObject = GameObject.Find("Lighting");
        Sunscript time = timeObject.GetComponent<Sunscript>();
        if (time.realTime == "10:05:00")
        {
            theAgent.SetDestination(destination.transform.position);
            animator.SetBool("ismoving", true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "wheelchairdestination")
        {
            animator.SetBool("ismoving", false);

        }
    }
    
}
