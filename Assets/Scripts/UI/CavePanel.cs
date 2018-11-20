using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CavePanel : MonoBehaviour
{

    public GameObject Cave_Panel;
    public GameObject Travelling_Panel;
    public GameObject beam;
    public GameObject Gem;

    public Button GOTOCAVE_Button;
    public Button Quit_Button;

    public Text Timer;

    public float beamspeed = -5f;


    void Update()
    {
        beam.transform.Rotate(new Vector3(0, 0, beamspeed), Space.Self);
        if(MapEvent.isTimerOn == true)
        {
            Timer.text =  CaveTime._caveTimer + " sec";
        }
        else
        {
            Timer.text = "600 sec";
        }


        
    }

    public void GOTOCAVEButton()
    {
        Gem.SetActive(false);
        Cave_Panel.SetActive(false);
        Travelling_Panel.SetActive(true);
        soundManager.instance.soundClick();
    }

    public void quitButton()
    {
        Cave_Panel.SetActive(false);
        soundManager.instance.soundClick();
    }
}
