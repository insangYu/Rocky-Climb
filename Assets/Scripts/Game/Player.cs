using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static int cnt = 0;
    public static bool isPlay;

    void Awake()
    {
        isPlay = false;
    }

    void Update()
    {
        if (isPlay == true && QuitPanel.isQuitOn == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                cnt++;
                Score.score++;
                soundManager.instance.soundGrab();
            }
        }
        Debug.Log("isPlay = " + isPlay);
        //Debug.Log("cnt = " + _cnt);
        //Debug.Log("cameraFollow = " + MapEvent._cameraFollow);
        //Debug.Log("isCaveOn = " + MapEvent._isCaveOn);
        //Debug.Log("_startani : " + PlayerAnimation._startani);
    }
}
