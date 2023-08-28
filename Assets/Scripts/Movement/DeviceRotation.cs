using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DeviceRotation
{
    public static bool gyrofound = false;
  
    public static float intervals = 0.0167f;
    public static bool HasGyro
    {
        get
        {
            return SystemInfo.supportsGyroscope;
        }
    }
    public static Quaternion Get()
    {
        if (!gyrofound)
        {
            initGyro();
        }

        return HasGyro
            ? ReadGyroscopeRotaion()
            : Quaternion.identity;
    }

    public static void initGyro()
    {
        if (HasGyro)
        {
            Input.gyro.enabled = true;
            Input.gyro.updateInterval = intervals;

        }
        gyrofound = true;
    }

    public static Quaternion ReadGyroscopeRotaion()
    {
        return new Quaternion(0.5f, -0.5f, 0.5f, 0.5f) * Input.gyro.attitude * new Quaternion(0f, 0, -4f *500, 0f); 
    }

}
