using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCaveAnimation : MonoBehaviour
{

    public static Animator CavePlayer;

    public GameObject ClearPanel;

    void Start()
    {
        CavePlayer = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (ClearAnimation.isCaveClear == true)
        {
            CavePlayer.enabled = true;
            CavePlayer.SetInteger("state", 2);
        }
        if (Player.cnt >= 1)
        {
            //CavePlayer.SetInteger("state", 3);
        }
    }

    public void cavestartEvent()
    {
        Player.isPlay = true;
        CavePlayer.enabled = false;
        //CavePlayer.SetInteger("state", 3);
        MapEvent.isCaveOn = true;
       
    }

    public void clearEvent()
    {
        ClearAnimation.isCaveClear = false;
        CavePlayer.SetInteger("state", 0);
        Invoke("BoxOn", 2);
    }

    public void BoxOn()
    {
        ClearPanel.SetActive(true);
        CaveClearPanel.isCaveClearPanelOn = true;
    }

}
