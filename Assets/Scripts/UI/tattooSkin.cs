using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tattooSkin : MonoBehaviour
{

    public Button tattoo1_Button;
    public Button tattoo2_Button;
    public Button tattoo3_Button;

    public GameObject tattoo1_selected;
    public GameObject tattoo2_selected;
    public GameObject tattoo3_selected;


    public void tattoo1Button()
    {
        tattoo1_selected.SetActive(true);
        tattoo2_selected.SetActive(false);
        tattoo3_selected.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void tattoo2Button()
    {
        tattoo1_selected.SetActive(false);
        tattoo2_selected.SetActive(true);
        tattoo3_selected.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void tattoo3Button()
    {
        tattoo1_selected.SetActive(false);
        tattoo2_selected.SetActive(false);
        tattoo3_selected.SetActive(true);

        soundManager.instance.soundClick();
    }
}
