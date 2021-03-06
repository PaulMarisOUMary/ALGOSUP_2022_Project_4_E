
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcmultipledestination : MonoBehaviour
{
    public int pivotPoint;
    Animator animator;
    void OnTriggerEnter(Collider other)
    {
        GameObject NPC = GameObject.Find("NPC11");
        animator = NPC.GetComponent<Animator>();
        animator.SetBool("isMoving", false);
        if (other.tag == "NPC")
        {
            pivotPoint = GetRandomNumber();
            WaitingTime();
            animator.SetBool("isMoving", true);
            if (pivotPoint == 6)
            {
                this.gameObject.transform.position = new Vector3(-11.8000002f, -0.50999999f, -79.0400009f); // good
            }
            if (pivotPoint == 5)
            {
                this.gameObject.transform.position = new Vector3(-14.1800003f, -0.50999999f, -56.1899986f); // good
            }
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(-13.0500002f, 3.00999999f, -53.3699989f); // good
            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-30.0300007f, 2.95000005f, -19.6299992f); // good
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-11.9490004f, 2.95000005f, -5.72700024f); // good
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-5.71000004f, 0.191999912f, -9.55000019f); // good
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-24.8999996f, 0.191999912f, -1.82000005f); // good
            }
        }
    }
    public int GetRandomNumber()
    {
        return Random.Range(0, 7);

    }
    IEnumerator WaitingTime()
    {
        yield return new WaitForSeconds(5f);
    }
}