using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
    public bool isCardValid = false;
    public GameObject status;
    public Material validMaterial , invalidMaterial;
    public enum AccessLevel : int
    {
        Students,
        Staff, 
        Admin
    };
    public AccessLevel AccessLevelRequired = AccessLevel.Staff;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<AccessCard>() != null)
            if ((int)collision.gameObject.GetComponent<AccessCard>().AccessLevelGranted >= (int)AccessLevelRequired)
                isCardValid = true;
    }

    void Update()
    {
        status.GetComponent<Renderer>().material = (isCardValid ? validMaterial : invalidMaterial);
    }
}