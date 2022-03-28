using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public GameObject handle;
    public bool isDoorLocked = true;

    void LockUpdate()
    {
        //if door z is near default position
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
        if (isDoorLocked)
        {
            doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            doorRigidbody.isKinematic = true;
        }else{
            doorRigidbody.constraints = RigidbodyConstraints.None;
            doorRigidbody.isKinematic = false;
        }
    }

    void changeLockingStatus()
    {
        if (handle.transform.localRotation.y > -0.5f)
            isDoorLocked = true;
        else
            isDoorLocked = false;
    }

    void Start()
    {

    }
    void Update()
    {
        changeLockingStatus();
        LockUpdate();
        Debug.Log(isDoorLocked);
    }
}
