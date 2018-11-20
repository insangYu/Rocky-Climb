using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizePanel : MonoBehaviour
{
    public GameObject Customize_Panel;
    public GameObject Start_Panel;
    public GameObject Left_Shoes;
    public GameObject Left_Shoes_Custom;
    public GameObject Right_Shoes;
    public GameObject Right_Shoes_Custom;
    public GameObject Gem;

    public Button backButton;
    
    public Camera SubCamera;

    public void BackButton()
    {
        soundManager.instance.soundClick();
        Customize_Panel.SetActive(false);
        Start_Panel.SetActive(true);
        SubCamera.gameObject.SetActive(false);
        Left_Shoes.SetActive(true);
        Left_Shoes_Custom.SetActive(false);
        Right_Shoes.SetActive(true);
        Right_Shoes_Custom.SetActive(false);
        PlayerAnimation.changeState(0);
        Gem.SetActive(true);

    }

   


}
