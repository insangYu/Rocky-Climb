using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{

    public GameObject Start_Panel;
    public GameObject Setting_Panel;
    public GameObject Customize_Panel;
    public GameObject Quest_Panel;
    public GameObject Progress_Panel;
    public GameObject Cave_Panel;
    public GameObject Gift_Panel;

    public Button Start_Button;
    public Button Customize_Button;
    public Button Gift_Button;
    public Button Quest_Button;
    public Button Progress_Button;
    public Button fb_Button;
    public Button Cave_Button;
    public Button Setting_Button;

    public GameObject head4_locked;
    public GameObject head4_dungeon;
    public GameObject head4_skin;

    public Camera SubCamera;

    public GameObject Logo;
    public GameObject Meter_Text;
    public GameObject Gem;

    public static bool isGiftOn;

    public void StartButton()
    {
        Start_Panel.SetActive(false);
        PlayerAnimation.startani = true;
        Meter_Text.SetActive(true);
        soundManager.instance.soundClick();
    }

    public void CustomizeButton()
    {
        PlayerAnimation.changeState(2);
        Start_Panel.SetActive(false);
        Customize_Panel.SetActive(true);
        SubCamera.gameObject.SetActive(true);
        soundManager.instance.soundClick();
        Gem.SetActive(false);

        if (CaveClearPanel.getHead4Item == true)
        {
            head4_dungeon.SetActive(true);
            head4_locked.SetActive(false);
            head4_skin.SetActive(true);
        }


    }

    public void GiftButton()
    {
        Gift_Panel.SetActive(true);
        isGiftOn = true;
        //BoxAnimation._Breakcnt = 0;
        soundManager.instance.soundClick();
    }

    public void QuestButton()
    {
        Quest_Panel.SetActive(true);
        soundManager.instance.soundClick();
    }

    public void ProgressButton()
    {
        Progress_Panel.SetActive(true);
        soundManager.instance.soundClick();
        Gem.SetActive(false);
    }

    public void fbButton()
    {
        Application.OpenURL("https://www.facebook.com/insangu");
        soundManager.instance.soundClick();
    }

    public void CaveButton()
    {
        soundManager.instance.soundClick();
        Cave_Panel.SetActive(true);
    }

    public void SettingButton()
    {
        Gem.SetActive(false);
        Setting_Panel.SetActive(true);
        soundManager.instance.soundClick();
    }

}
