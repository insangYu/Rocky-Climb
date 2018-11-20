using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour {


    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1440, 2560, true);
    }
}
