using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    int hours = 0;
    [SerializeField] int hourSpeed = 60;

    string AMPM = "AM";

    int days = 1;
    [SerializeField] int daySpeed = 13;

    int months = 1;
    [SerializeField] int monthSpeed = 30;

    int years = 1;
    [SerializeField] int yearSpeed = 12;

    float elapsed;

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= hourSpeed)
        {
            elapsed = 0f;
            hours ++;

            if (hours >= daySpeed)
            {
                if (AMPM == "PM")
                {
                    hours = 0;
                    days++;

                    AMPM = "AM";

                   if (days >= monthSpeed)
                    {
                        days = 0;
                        months ++;
                    
                        if (months >= yearSpeed)
                        {
                            months = 0;
                            years ++;
                        }
                    }
                }
                else
                {
                    hours = 1;
                    AMPM = "PM";
                }
            }

        Debug.Log(months + "/" + days + " " + hours + AMPM);  
        }
    }
}
