using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterManager : MonoBehaviour
{

    public GameObject Flag;
    public GameObject player;

    public static int m_Meter;

    public Text Meter_Text;

    void Start()
    {
        m_Meter = 205;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Player.isPlay == true)
        {
            m_Meter = (int)(Flag.transform.position.y - player.transform.position.y);
            Meter_Text.text = m_Meter + " M";
        }
    }
}
