using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    public GameObject YourSelf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            YourSelf.transform.position = new Vector3(0, 1, 0);
            YourSelf.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
