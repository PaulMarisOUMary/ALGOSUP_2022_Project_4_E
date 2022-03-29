using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC1Behaviour : MonoBehaviour
{
    public GameObject destination;
    public bool isMoving;
    private bool debugVar;
    private string startingtimeNPC;
    public bool wantabreak;
    private GameObject childdestination;
    Animator animator;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        GameObject global = GameObject.Find("GlobalScript");
        RandomNPCscript getrandomtime = global.GetComponent<RandomNPCscript>();
        startingtimeNPC = getrandomtime.GetRandomStartingTime();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject timeObject = GameObject.Find("Lighting");
        Sunscript actualtime = timeObject.GetComponent<Sunscript>();
        if ((actualtime.realTime == startingtimeNPC) || (debugVar == true))
        {
            isMoving = true;
        }
        
        if (actualtime.realTime == "10:45:00")
        {
            GameObject breaktime = GameObject.Find("GlobalScript");
            RandomNPCscript getbreakbool = breaktime.GetComponent<RandomNPCscript>();
            wantabreak = getbreakbool.WantToTakeABreak();
            if (wantabreak == true) {
                if (gameObject.name == "NPC1")
                {
                    GameObject.Find("NPC1destination").transform.position = new Vector3(-2.03699994f, 0.061999999f, 0.291999996f);

                }
                isMoving = true;
            }

        }
        if (isMoving == true)
        {
            theAgent.SetDestination(destination.transform.position);
            animator.SetBool("isMoving", true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "NPC1destination")
        {
            isMoving = false;
            animator.SetBool("isMoving", false);
        }
        
    }

}
