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

        if (handle.transform.localRotation.y > -0.02f && door.transform.localRotation.z < 0.001f)
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
