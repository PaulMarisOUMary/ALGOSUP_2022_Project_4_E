using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sunscript : MonoBehaviour
{
    public string realTime;
    public int seconds;
    public int minutes;
    public int hours;
    public int over;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTime());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator UpdateTime()
    {
        while (true)
        {
            var today = System.DateTime.Now;
            today = today.AddSeconds(seconds);
            today = today.AddMinutes(minutes);
            today = today.AddHours(hours);
            // night/day cycle :
            over = today.Hour;
            GameObject daytime = GameObject.Find("Lighting");
            GameObject ChildGameObject1 = daytime.transform.GetChild(0).gameObject;
            if (over <= 6 || over >= 18) {
                ChildGameObject1.SetActive(false);
            }
            else
            {
                ChildGameObject1.SetActive(true);

            }
            realTime = today.ToString("HH:mm:ss");
            yield return new WaitForSeconds(0.2f);
            
        }
    }
  
}

