using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
    public enum AccessLevel : int
    {
        Students,
        Staff, 
        Admin
    };
    public AccessLevel AccessLevelRequired = AccessLevel.Staff;

    public bool isCardValid = false;

    //colision detection into test the access level :ok_hand:
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.GetComponent<AccessCard>().AccessLevelGranted != null)
        {
            if ((int)collision.gameObject.GetComponent<AccessCard>().AccessLevelGranted >= (int)AccessLevelRequired && !isCardValid)
            {
                isCardValid = true;
            }
            else
            {
                isCardValid = false;
            }
        }
    }    

    void Start()
    {
        
    }

    void Update()
    {
        

    }
}