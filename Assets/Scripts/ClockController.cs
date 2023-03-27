using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{   
    int hour;
    int minute;
    int second;
    int hourMultiplier = 30;
    int minuteMultiplier = 6;
    int oldSeconds;

    [SerializeField] GameObject secondHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject hourHand;

    void Start() 
    {
        UpdateTimer();
    }

    // Update is called once per frame
    void Update()
    {
        DateTime localTime = DateTime.Now;

        hour = localTime.Hour;
        second = localTime.Second;
        minute = localTime.Minute;

        if (second != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = second;
    }

    void UpdateTimer()
    {
        secondHand.transform.rotation = Quaternion.AngleAxis(second * minuteMultiplier, Vector3.right);
        minuteHand.transform.rotation = Quaternion.AngleAxis(minute * minuteMultiplier, Vector3.right);
        hourHand.transform.rotation = Quaternion.AngleAxis(hour * hourMultiplier, Vector3.right);
    }
}
