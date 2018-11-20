using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftPanel : MonoBehaviour
{

    public GameObject Gift_Panel;

    public Button Double_Reward;
    public Button playButton;

    public void DoubleReward()
    {
        //광고
        soundManager.instance.soundClick();
    }

    public void PlayButton()
    {
        BoxAnimation.Breakcnt = 0;
        Invoke("Return", 0.5f);
        soundManager.instance.soundClick();
    }

    public void Return()
    {
        Gift_Panel.SetActive(false);
        soundManager.instance.soundClick();
    }

}
