using System;
using UnityEngine;
public class Clock : MonoBehaviour {

    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    public bool continuous;
    void UpdateContinuous () {
//        Debug.Log(DateTime.Now.Hour);
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        secondsTransform.localRotation = 
            Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);    
    }
    void UpdateDiscrete () {
//        Debug.Log(DateTime.Now.Hour);
        hoursTransform.localRotation = 
            Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = 
            Quaternion.Euler(0f, DateTime.Now.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = 
            Quaternion.Euler(0f, DateTime.Now.Second * degreesPerSecond, 0f);    
    }

    void Update () {
        if (continuous) {
            UpdateContinuous();
        }
        else {
            UpdateDiscrete();
        }
    }
}