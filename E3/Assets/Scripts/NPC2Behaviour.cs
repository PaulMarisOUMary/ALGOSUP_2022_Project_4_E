using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC2Behaviour : MonoBehaviour
{
    public GameObject destination;
    public bool isMoving;
    private bool debugVar;
    private string startingtimeNPC;
    public bool wantabreak;
    private bool isSitting;
    private NavMeshObstacle navObstacleInteraction;
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
            if (wantabreak == true)
            {
                if (gameObject.name == "NPC2")
                {
                    GameObject.Find("NPC2destination").transform.position = new Vector3(-3.03699994f, 0.061999999f, 0.291999996f);

                }
                isMoving = true;
            }

        }
        if (isMoving == true)
        {
            theAgent.SetDestination(destination.transform.position);
            animator.SetBool("isMoving", true);
        }
        if ((isMoving == false) && (isSitting == true)){
            GameObject.Find("NPC2").transform.rotation = GameObject.Find("Chair_Conference_Red2").transform.rotation;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "NPC2destination")
        {
            isMoving = false;
            animator.SetBool("isMoving", false);
            IsGonnaSit();
        }

    }
    private void IsGonnaSit()
    {
        isSitting = true;
        animator.SetBool("WantToSit", true);
        StartCoroutine(WaitingAnimation());
    }
    IEnumerator WaitingAnimation()
    {
        navObstacleInteraction = GameObject.Find("Chair_Conference_Red2").GetComponent<NavMeshObstacle>();
        GameObject.Find("Chair_Conference_Red2").transform.position = new Vector3(-12.4200008f, -0.218740463f, -9.2446219f);
        GameObject.Find("NPC2destination").transform.position = new Vector3(-12.4370001f, 0.0341110229f, -9.24711151f);
        navObstacleInteraction.enabled = false;
        theAgent.SetDestination(destination.transform.position);
        yield return new WaitForSeconds(2.05f);
        animator.SetBool("isMoving", false);
        animator.SetBool("WantToSit", false);
        animator.SetBool("WantToStand", false);

    }
    //GameObject.Find("NPCsitting").transform.rotation = GameObject.Find("ch2").transform.rotation;
    // Chair_Conference_Red (2)
}
