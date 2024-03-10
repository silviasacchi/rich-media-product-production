//Purpose of this script is to check if a headset is plugged in or not. I followed this tutorial: https://www.youtube.com/watch?v=UlqdHrfXppo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!XRSettings.isDeviceActive) //If there is no active XR device, then...
        {
            Debug.Log("No XR Device Detected"); //Log that there is no XR device detected.
        }
        //Otherwise, if there is an active device but it's the mock HMD, then...
        else if(XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD"
        || XRSettings.loadedDeviceName == "MockHMD Display")) 
        {
            Debug.Log("Mock HMD Detected"); //Log that the mock HMD is detected.
        }
        else
        {
            Debug.Log("We Have an External Device Detected" + XRSettings.loadedDeviceName); //Log that there is an external device detected and its name.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
