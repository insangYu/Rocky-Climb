using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitPanel : MonoBehaviour
{

    public GameObject Quit_Panel;
    
    public Button Yes_Button;
    public Button No_Button;

    public static bool isQuitOn = false;


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit_Panel.SetActive(true);
            Time.timeScale = 0;
            
        }
    }

    public void YesButton()
    {
        Application.Quit();
        soundManager.instance.soundClick();
        isQuitOn = true;
    }

    public void NoButton()
    {
        soundManager.instance.soundClick();
        Time.timeScale = 1;
        Quit_Panel.SetActive(false);
        Invoke("makeQuit", 3);
    }

    public void makeQuit()
    {
        isQuitOn = false;
    }
}
