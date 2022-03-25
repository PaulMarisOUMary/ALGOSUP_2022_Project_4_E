
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCdestination : MonoBehaviour
{
    public GameObject destination;
    public bool NPCmouvement;
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
        if (time.realTime == "10:50:05")
        {
            NPCmouvement = true;
        }
        if (NPCmouvement == true)
        {
            animator.SetBool("switchAnim", true);
            theAgent.SetDestination(destination.transform.position);

        }
    }
}

