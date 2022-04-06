using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door , cardReader;
    public bool cardReaderUnlockStatus = false;
    private bool doorMoved = false;
    private Quaternion doorStartPosition;

    void LockUpdate()
    {
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
        bool validCard = cardReader.GetComponent<CardReader>().isCardValid;
        if (!validCard)
            doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        else
            doorRigidbody.constraints = RigidbodyConstraints.None;
        doorRigidbody.isKinematic = !validCard;
        if (!(Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.05f) && !doorMoved)
            doorMoved = true;
        if (doorMoved && (Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.0005f))
        {
            doorMoved = false;
            cardReader.GetComponent<CardReader>().isCardValid = false;
        }
    }

    void Start()
    {
        doorStartPosition = door.transform.rotation;
    }
    void Update()
    {
        if (cardReader != null)
            cardReaderUnlockStatus = cardReader.GetComponent<CardReader>().isCardValid;
        else
            cardReaderUnlockStatus = true;
        LockUpdate();
    }
}