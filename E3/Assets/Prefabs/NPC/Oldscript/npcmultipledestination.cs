
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcmultipledestination : MonoBehaviour
{
    public int pivotPoint;
    void OnTriggerEnter(Collider other)
    {
            if(other.tag == "NPC")
        {
            if (pivotPoint == 5)
            {
                pivotPoint = 6;
            }
            if (pivotPoint == 4)
            {

                this.gameObject.transform.position = new Vector3(8.84000015f, 1.11000001f, 20.4799995f);
                pivotPoint = 5;
                print("ok jsuis la pos5");
            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(4.8499999f, 7.03999996f, 8.81999969f);
                pivotPoint = 4;
                print("ok jsuis la pos4");
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-1.44000006f, 5.03000021f, 15.9700003f);
                pivotPoint = 3;
                print("ok jsuis la pos3");
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(13.8800001f, 1.36000001f, 12.5500002f);
                pivotPoint = 2;
                print("ok jsuis la pos2");
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(6.86000013f, 0.699999988f, 9.64000034f);
                pivotPoint = 1;
                print("ok jsuis la pos1");
            }
            
        }
    }
}