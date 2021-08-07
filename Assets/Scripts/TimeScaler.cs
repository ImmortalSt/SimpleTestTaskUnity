using System;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    public void SetTimeScaler(float newTimeScale)
    {
        if (newTimeScale < 0 || newTimeScale > 1)
            throw new ArgumentOutOfRangeException();

        Time.timeScale = newTimeScale;
    }
}
