
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcmultipledestination2 : MonoBehaviour
{
    public int pivotPoint;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            pivotPoint = GetRandomNumber();
            if (pivotPoint == 6)
            {
                this.gameObject.transform.position = new Vector3(-7.17600012f, -0.50999999f, -41.3019981f);
            }
            if (pivotPoint == 5)
            {
                this.gameObject.transform.position = new Vector3(-7.53999996f, -0.50999999f, -15.0500002f);
            }
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(0.889999986f, -0.50999999f, -1.91999996f);
            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-27.1000004f, -0.50999999f, -63.4900017f);
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-14.0699997f, -0.50999999f, -55.6100006f);
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-13.4200001f, -0.50999999f, -62.3300018f);
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-9.31999969f, -0.50999999f, -71.8499985f);
            }
        }
    }
    public int GetRandomNumber()
    {
        return Random.Range(0, 7);

    }
}