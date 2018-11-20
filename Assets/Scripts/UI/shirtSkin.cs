using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shirtSkin : MonoBehaviour {

    public Button shirt1_Button;
    public Button shirt2_Button;
    public Button shirt3_Button;

    public GameObject shirt1_selected;
    public GameObject shirt2_selected;
    public GameObject shirt3_selected;
    
    public GameObject shirt1ofplayer;
    public GameObject shirt2ofplayer;
    public GameObject shirt3ofplayer;


    public void shirt1Button()
    {
        shirt1_selected.SetActive(true);
        shirt2_selected.SetActive(false);
        shirt3_selected.SetActive(false);

        shirt1ofplayer.SetActive(true);
        shirt2ofplayer.SetActive(false);
        shirt3ofplayer.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void shirt2Button()
    {
        shirt1_selected.SetActive(false);
        shirt2_selected.SetActive(true);
        shirt3_selected.SetActive(false);

        shirt1ofplayer.SetActive(false);
        shirt2ofplayer.SetActive(true);
        shirt3ofplayer.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void shirt3Button()
    {
        shirt1_selected.SetActive(false);
        shirt2_selected.SetActive(false);
        shirt3_selected.SetActive(true);

        shirt1ofplayer.SetActive(false);
        shirt2ofplayer.SetActive(false);
        shirt3ofplayer.SetActive(true);

        soundManager.instance.soundClick();
    }
}
