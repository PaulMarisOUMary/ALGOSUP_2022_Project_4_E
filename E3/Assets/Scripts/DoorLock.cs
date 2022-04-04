using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public GameObject handle;
    public bool bonusLockAccess = false;
    public GameObject bonusLock;

    void LockUpdate()
    {
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();

        if (handle.transform.localRotation.y > -0.02f && door.transform.localRotation.z < 0.001f && bonusLockAccess)
        {
            doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            doorRigidbody.isKinematic = true;
        }else{
            doorRigidbody.constraints = RigidbodyConstraints.None;
            doorRigidbody.isKinematic = false;
        }
    }

    void bonusLockUpdate()
    {
        if (bonusLock != null)
        {
            bonusLockAccess = bonusLock.GetComponent<CardReader>().isCardValid;
        }
        else
        {
            bonusLockAccess = true;
        }
    }

    void Start()
    {

    }
    void Update()
    {
        bonusLockUpdate();
        LockUpdate();
    }
}
