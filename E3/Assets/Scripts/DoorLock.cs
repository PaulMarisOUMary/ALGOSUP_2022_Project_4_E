using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door , cardReader;
    public bool doorMoved = false;
    private Quaternion doorStartPosition;
    void Start(){doorStartPosition = door.transform.rotation;}
    void Update()
    {
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
        bool validCard = cardReader.GetComponent<CardReader>().isCardValid;
        doorRigidbody.constraints = (!cardReader.GetComponent<CardReader>().isCardValid ? RigidbodyConstraints.FreezeRotation : RigidbodyConstraints.None);
        doorRigidbody.isKinematic = !cardReader.GetComponent<CardReader>().isCardValid;
        doorMoved = !(Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.05f) || doorMoved;
        if (doorMoved && (Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.0005f))
        {
            doorMoved = false;
            cardReader.GetComponent<CardReader>().isCardValid = false;
        }
    }
}