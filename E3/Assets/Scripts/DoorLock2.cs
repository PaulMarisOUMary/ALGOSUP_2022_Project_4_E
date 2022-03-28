// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DoorLock : MonoBehaviour
// {
//     public GameObject door;
//     public GameObject handle;
//     private bool isDoorLocked = true;

//     void lockingDoor(bool locked)
//     {
//         Rigidbody doorRigidbody = door.GetComponent<Rigidbody>();
//         if (isDoorLocked)
//         {
//             doorRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
//             doorRigidbody.isKinematic = true;
//         }else{
//             doorRigidbody.constraints = RigidbodyConstraints.None;
//             doorRigidbody.isKinematic = true;
//         }
//     }

//     void changeLockingStatus()
//     {
//         if (handle.GetComponent<XRBaseInteractable>().isSelected)
//         {
//             isDoorLocked = true;
//         }
//         isDoorLocked = false;
//     }

//     void Start()
//     {

//     }
//     void Update()
//     {
//         changeLockingStatus();
//         lockingDoor(isDoorLocked);
//     }
// }
