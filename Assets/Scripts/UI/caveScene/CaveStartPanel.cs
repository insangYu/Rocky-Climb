using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaveStartPanel : MonoBehaviour
{

    public GameObject caveStartPanel;

    void Start()
    {

    }

    void Update()
    {

    }

    public void startButton()
    {
        MapEvent.cameraFollow = true;
        caveStartPanel.SetActive(false);
        PlayerCaveAnimation.CavePlayer.SetInteger("state", 1);
        soundManager.instance.soundClick();
    }

}
