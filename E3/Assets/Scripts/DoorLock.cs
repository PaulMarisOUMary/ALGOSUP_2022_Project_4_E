using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public bool cardReaderUnlockStatus = false;
    public GameObject cardReader;
    private bool doorMoved = false;
    private Quaternion doorStartPosition;

    void LockUpdate()
    {
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
        bool validCard = cardReader.GetComponent<CardReader>().isCardValid;
        if (!validCard)
        {
            doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            doorRigidbody.isKinematic = true;
        }else{
            doorRigidbody.constraints = RigidbodyConstraints.None;
            doorRigidbody.isKinematic = false;
        }
        //unlock door
        //check if the door moved by at least 5°
        if (!(Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.05f) && !doorMoved)
        {
            doorMoved = true;
        }
        if (doorMoved && (Mathf.Abs(door.transform.rotation.y - doorStartPosition.y)<0.0005f))
        {
            doorMoved = false;
            cardReader.GetComponent<CardReader>().isCardValid = false;
        }
    }

    void CardReaderUpdate()
    {
        if (cardReader != null)
            cardReaderUnlockStatus = cardReader.GetComponent<CardReader>().isCardValid;
        else
            cardReaderUnlockStatus = true;
    }

    void Start()
    {
        doorStartPosition = door.transform.rotation;
    }
    void Update()
    {
        CardReaderUpdate();
        LockUpdate();
    }
}