using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
    public bool isCardValid = false;
    public GameObject status;
    public Material validMaterial , invalidMaterial;
    public enum AccessLevel : int{Students,Staff, Admin};
    public AccessLevel AccessLevelRequired = AccessLevel.Staff;
    void OnCollisionEnter(Collision collision){isCardValid = (int)collision.gameObject.GetComponent<AccessCard>().AccessLevelGranted >= (int)AccessLevelRequired;}
    void Update(){status.GetComponent<Renderer>().material = (isCardValid ? validMaterial : invalidMaterial);}
}