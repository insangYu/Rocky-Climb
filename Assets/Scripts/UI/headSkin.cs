using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class headSkin : MonoBehaviour
{

    public Button head1_Button;
    public Button head2_Button;
    public Button head3_Button;
    public Button head4_Button;

    public GameObject head1_selected;
    public GameObject head2_selected;
    public GameObject head3_selected;
    public GameObject head4_selected;

    public GameObject head1ofplayer;
    public GameObject head2ofplayer;
    public GameObject head3ofplayer;
    public GameObject head4ofplayer;

    public GameObject head4_locked;

    public GameObject head4_dungeon;


    public void head1Button()
    {
        head1_selected.SetActive(true);
        head2_selected.SetActive(false);
        head3_selected.SetActive(false);
        head4_selected.SetActive(false);

        head1ofplayer.SetActive(true);
        head2ofplayer.SetActive(false);
        head3ofplayer.SetActive(false);
        head4ofplayer.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void head2Button()
    {
        head1_selected.SetActive(false);
        head2_selected.SetActive(true);
        head3_selected.SetActive(false);
        head4_selected.SetActive(false);

        head1ofplayer.SetActive(false);
        head2ofplayer.SetActive(true);
        head3ofplayer.SetActive(false);
        head4ofplayer.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void head3Button()
    {
        head1_selected.SetActive(false);
        head2_selected.SetActive(false);
        head3_selected.SetActive(true);
        head4_selected.SetActive(false);

        head1ofplayer.SetActive(false);
        head2ofplayer.SetActive(false);
        head3ofplayer.SetActive(true);
        head4ofplayer.SetActive(false);

        soundManager.instance.soundClick();
    }

    public void head4Button()
    {
        if(CaveClearPanel.getHead4Item == true)
        {
            head1_selected.SetActive(false);
            head2_selected.SetActive(false);
            head3_selected.SetActive(false);
            head4_selected.SetActive(true);

            head1ofplayer.SetActive(false);
            head2ofplayer.SetActive(false);
            head3ofplayer.SetActive(false);
            head4ofplayer.SetActive(true);

            soundManager.instance.soundClick();
        }
        
    }

}
