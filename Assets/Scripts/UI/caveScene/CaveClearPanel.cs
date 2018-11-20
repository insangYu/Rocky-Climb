using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveClearPanel : MonoBehaviour
{

    public static bool isCaveClearPanelOn;
    public static bool getHead4Item;

    public static int BreakCnt = 0;

    public GameObject newHead;
    public GameObject specialBox;


    void Start()
    {
        
    }

    void Update()
    {

        if(isCaveClearPanelOn == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                BreakCnt++;
            }
        }
        switch (BreakCnt)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:
                getHead4Item = true;
                specialBox.SetActive(false);
                newHead.SetActive(true);
                break;
        }
        //Debug.Log(isCaveClearPanelOn);
        //Debug.Log("BreakCnt : " + BreakCnt);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Mountain1");
        MapEvent.isCaveOn = false;
        Player.cnt = 0;
        MapEvent.isTimerOn = false;
        soundManager.instance.soundClick();
    }
}
