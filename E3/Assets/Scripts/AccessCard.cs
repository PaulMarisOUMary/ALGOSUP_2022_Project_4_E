using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessCard : MonoBehaviour
{
    public enum AccessLevel : int
    {
        Students,
        Staff, 
        Admin
    };
    public AccessLevel AccessLevelGranted = AccessLevel.Students;
}