using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

    void Update()
    {

        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation =
            Quaternion.Euler(hoursToDegrees * (float)time.TotalHours, 0f, 0f);
        minutesPivot.localRotation =
            Quaternion.Euler(minutesToDegrees * (float)time.TotalMinutes, 0f, 0f);
        secondsPivot.localRotation =
            Quaternion.Euler(secondsToDegrees * (float)time.TotalSeconds, 0f, 0f);
    }
}
