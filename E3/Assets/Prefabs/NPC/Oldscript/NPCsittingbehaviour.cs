using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCsittingbehaviour : MonoBehaviour
{
    public GameObject destination;
    public bool NPCmouvement;
    private string startingtimeNPC;
    public bool sitting;
    public bool breaktime;
    Animator animator;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        // test starting time
        GameObject startingtime = GameObject.Find("GlobalScript");
        RandomNPCscript getstartingtime = startingtime.GetComponent<RandomNPCscript>();
        startingtimeNPC = getstartingtime.GetRandomStartingTime();

    }

    // Update is called once per frame
    void Update()
    {
        GameObject timeObject = GameObject.Find("Lighting");
        Sunscript time = timeObject.GetComponent<Sunscript>();
        if (time.realTime == "10:50:05")
        {
            NPCmouvement = true;
            sitting = true;
        }
        if (NPCmouvement == true)
        {
            //animator.SetBool("switchAnim", true);
            theAgent.SetDestination(destination.transform.position);
            NPCmouvement = false;
            animator.SetBool("ismoving", true);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "NPCsittingdestination" && sitting == true)
        {
            animator.SetBool("wanttosit", true);
            StartCoroutine(waitingAnimation());

            // Vector3(-6,0.5,3.23000002)


        }
        if ((other.gameObject.name == "NPCsittingdestination") && (breaktime == true))
        {
            animator.SetBool("ismoving", false);
            animator.SetBool("notmoving", true);
        }
    }
    
    IEnumerator waitingAnimation()
    {
        yield return new WaitForSeconds(2.05f);
        GameObject.Find("NPCsitting").transform.position = new Vector3(-6f, 0.5f, 3.23000002f);
        GameObject.Find("NPCsittingdestination").transform.position = new Vector3(-6f, 0.5f, 3.23000002f);
        theAgent.SetDestination(destination.transform.position);
        animator.SetBool("ismoving", false);
        animator.SetBool("wanttosit", false);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "NPCsittingdestination" )
        {
            GameObject.Find("NPCsitting").transform.rotation = GameObject.Find("ch2").transform.rotation;
            sitting = false;
        }
        
    }
}
