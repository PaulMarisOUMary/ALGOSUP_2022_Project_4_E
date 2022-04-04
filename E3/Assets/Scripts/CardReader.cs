using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{

    public enum AccessLevel : int
    {
        Students,
        Staff, 
        Admin
    };
    public AccessLevel AccessLevelRequired = AccessLevel.Staff;

    public bool isCardValid = false;
    public GameObject status;
    public Material validMaterial;
    public Material invalidMaterial;

    //colision detection into test the access level :ok_hand:
    private IEnumerator delay()
    {
        isCardValid = true;
        yield return new WaitForSeconds(15.0f);
        isCardValid = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.collider.gameObject.GetComponent<AccessCard>() != null)
            if ((int)collision.collider.gameObject.GetComponent<AccessCard>().AccessLevelGranted >= (int)AccessLevelRequired)
                {
                    isCardValid = true;
                    Coroutine coroutine = StartCoroutine(delay());
                    Debug.Log("Access Granted");
                }
    }

    void StatusIndicatorUpdate()
    {
        if (isCardValid)
        {
            status.GetComponent<Renderer>().material = validMaterial;
        }
        else
        {
            status.GetComponent<Renderer>().material = invalidMaterial;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        StatusIndicatorUpdate();
    }
}