using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingPanel : MonoBehaviour
{
    
    public GameObject Setting_Panel;
    public GameObject Gem;

    public Button Back_Button;
    public Button fb_Button;
    public Button twitter_Button;
    public Button instagram_Button;
    public Button NoAds_Button;
    public Button Restore_Button;
    public Button HowToPlay_Button;
    public Button newM_Button;
    public Button Bug_Button;
    public Button more_Button;

    public Button MusicOn_Button;
    public Button MusicOff_Button;

    public Button VibeOn_Button;
    public Button VibeOff_Button;

    void Start()
    {
        
    }

    public void BackButton()
    {
        Setting_Panel.SetActive(false);
        soundManager.instance.soundClick();
        Gem.SetActive(true);
    }

    public void fbButton()
    {
        Application.OpenURL("https://www.facebook.com/insangu");
        soundManager.instance.soundClick();
    }

    public void twitterButton()
    {
        soundManager.instance.soundClick();
    }

    public void instagramButton()
    {
        Application.OpenURL("https://www.instagram.com/iiiinsang/");
        soundManager.instance.soundClick();
    }

    public void NoAdsButton()
    {
        soundManager.instance.soundClick();
    }

    public void RestoreButton()
    {
        soundManager.instance.soundClick();
    }

    public void HowToPlayButton()
    {
        soundManager.instance.soundClick();
    }

    public void newMButton()
    {
        soundManager.instance.soundClick();
    }

    public void BugButton()
    {
        soundManager.instance.soundClick();
    }

    public void moreButton()
    {
        soundManager.instance.soundClick();
    }

    public void MusicOnButton()
    {
        MusicOn_Button.gameObject.SetActive(false);
        MusicOff_Button.gameObject.SetActive(true);
        soundManager.instance.soundClick();
        soundManager.instance.soundOff();
    }

    public void MusicOffButton()
    {
        MusicOn_Button.gameObject.SetActive(true);
        MusicOff_Button.gameObject.SetActive(false);
        soundManager.instance.soundClick();
        soundManager.instance.soundOn();

    }

    public void VibeOnButton()
    {
        VibeOn_Button.gameObject.SetActive(false);
        VibeOff_Button.gameObject.SetActive(true);
        soundManager.instance.soundClick();
    }

    public void VibeOffButton()
    {
        VibeOn_Button.gameObject.SetActive(true);
        VibeOff_Button.gameObject.SetActive(false);
        soundManager.instance.soundClick();
    }
}
