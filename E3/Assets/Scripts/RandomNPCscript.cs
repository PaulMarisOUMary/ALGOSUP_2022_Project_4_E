using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNPCscript : MonoBehaviour
{
    private int randomizeArrival;
    private int TakingaBreak;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public string GetRandomStartingTime()
    {
        randomizeArrival = Random.Range(1, 101);
        if (randomizeArrival == 1)
        {
            return "08:30:00";
        }
        if ((randomizeArrival >= 2) && (randomizeArrival < 5))
        {
            return "08:35:00";
        }
        if ((randomizeArrival >= 6) && (randomizeArrival < 14))
        {
            return "08:40:00";
        }
        if ((randomizeArrival >= 14) && (randomizeArrival < 30))
        {
            return "08:45:00";
        }
        if ((randomizeArrival >= 30) && (randomizeArrival < 80))
        {
            return "08:50:00";
        }
        if ((randomizeArrival >= 80) && (randomizeArrival < 100))
        {
            return "08:55:00";
        }
        if (randomizeArrival == 100)
        {
            return "09:00:00";
        }
        print("error, no starting time found !");
        return "No time found";
    }
    public bool WantToTakeABreak()
    {
        TakingaBreak = Random.Range(1, 3);
        if (TakingaBreak == 1)
        {
            return true;

        }else
        {
            return false;

        }
    }
}
