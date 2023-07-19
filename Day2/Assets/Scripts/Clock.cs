using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    public int ChangeTime = 0;
    private void Update()
    {
        DateTime currentTime = DateTime.Now;

        float hours = currentTime.Hour + ChangeTime;
        float minutes = currentTime.Minute;
        float seconds = currentTime.Second;

        //Debug.Log($"h: {hours} m: {minutes} s: {seconds}");
        float hourAngle = 360f * ((hours % 12) + minutes / 60f) / 12f;
        float minuteAngle = 360f * minutes / 60f;
        float secondAngle = 360f * seconds / 60f;

        hourHand.localRotation = Quaternion.Euler(0f, hourAngle, 0f);
        minuteHand.localRotation = Quaternion.Euler(0f, minuteAngle, 0);
        secondHand.localRotation = Quaternion.Euler(0f, secondAngle, 0);
    }
}
