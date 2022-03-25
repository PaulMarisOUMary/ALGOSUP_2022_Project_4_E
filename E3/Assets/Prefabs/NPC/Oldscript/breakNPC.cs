using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class breakNPC : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent theAgent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject timeObject = GameObject.Find("Lighting");
        Sunscript time = timeObject.GetComponent<Sunscript>();
        if (time.realTime == "10:45:00")
        {
            GameObject npc = GameObject.Find("NPCsitting");
            NPCsittingbehaviour NPCsittingbehaviour = npc.GetComponent<NPCsittingbehaviour>();
            theAgent = npc.GetComponent<NavMeshAgent>();
            GameObject.Find("NPCsittingdestination").transform.position = new Vector3(14.84000015f, 1.11000001f, 20.4799995f);
            NPCsittingbehaviour.NPCmouvement = true;
            NPCsittingbehaviour.breaktime = true;
            //  theAgent.SetDestination(mouvement.destination.transform.position);
            // already call in NPCdestination
        }
    }
}
