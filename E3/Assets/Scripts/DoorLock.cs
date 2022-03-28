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
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
        bool canBeLocked = false;

        if (door.transform.position.z < 0.1f)
            canBeLocked = true;
        else
            canBeLocked = false;

        if (isDoorLocked && canBeLocked)
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
        if (handle.transform.localRotation.y < -0.5f)
            isDoorLocked = false;
        else
            isDoorLocked = true;
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
