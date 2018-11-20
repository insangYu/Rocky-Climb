using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MapEvent : MonoBehaviour
{

    public GameObject Travelling_Panel;

    public static bool isTimerOn;
    public static bool isCaveOn;
    public static bool cameraFollow;

    void Start()
    {
        isCaveOn = false;
        cameraFollow = false;
        isTimerOn = false;
    }

    void Update()
    {

    }

    public void GOTOCAVE_Event()
    {
        isTimerOn = true;
        cameraFollow = true;
        isCaveOn = true;
        Travelling_Panel.SetActive(false); 
        SceneManager.LoadScene("CaveScene");
        Player.cnt = 0;
        Player.isPlay = false;
    }

    public void nextMountain()
    {
        Player.cnt = 0;
        SceneManager.LoadScene("Mountain2");
    }

    public void soundEvent()
    {
        soundManager.instance.soundAppear();
    }
}
