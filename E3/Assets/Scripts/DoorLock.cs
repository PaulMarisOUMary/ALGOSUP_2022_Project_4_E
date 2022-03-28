using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public GameObject handle;

    void LockUpdate()
    {
        Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();

        bool doorPositionLock = false;
        bool handleLock = true;

        if (handle.transform.localRotation.y < -0.5f)
            handleLock = false;
        else
            handleLock = true;

        if (door.transform.position.z < 0.1f)
            doorPositionLock = true;
        else
            doorPositionLock = false;

        if (handleLock && doorPositionLock)
        {
            doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
            doorRigidbody.isKinematic = true;
        }else{
            doorRigidbody.constraints = RigidbodyConstraints.None;
            doorRigidbody.isKinematic = false;
        }
    }

    void Start()
    {

    }
    void Update()
    {
        LockUpdate();
    }
}
