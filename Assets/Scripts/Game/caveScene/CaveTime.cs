using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTime : MonoBehaviour
{

    public static float caveTimer = 600f;
    public static int _caveTimer;


    void Start()
    {

    }

    void Update()
    {
        if(MapEvent.isTimerOn == true)
        {
            caveTimer -= Time.deltaTime;
            _caveTimer = (int)caveTimer;
        }
        
        if(_caveTimer == 0)
        {
            MapEvent.isTimerOn = false;
            caveTimer = 600f;
        }

    }
}
