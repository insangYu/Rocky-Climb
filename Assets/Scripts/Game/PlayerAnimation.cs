using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public GameObject score;
    public GameObject Travelling_Panel2;
    public GameObject Meter_Text;

    public static Animator Player_Animator;
    const int STATE_READY = 0;
    const int STATE_START = 1;
    const int STATE_CUSTOMIZE = 2;
    const int STATE_CLEAR = 3;
    const int STATE_LGRAB = 4;
    const int STATE_IDLE = 5;
    const int STATE_RGRAB = 6;

    public static int currentAnimationState = STATE_READY;

    public static bool startani = false;

    void Start()
    {
        Player_Animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (startani == true)
        {
            changeState(STATE_START);
        }
        if (ClearAnimation.isClear == true)
        {
            Player_Animator.enabled = true;
            changeState(STATE_CLEAR);
            //Meter_Text.SetActive(false);
            MeterManager.m_Meter = 0;
        }
        if(Player.cnt >= 1)
        {
            changeState(STATE_IDLE);
        }
        
    }

    public void startEvent()
    {
        changeState(STATE_IDLE);
        Player.isPlay = true;
        score.SetActive(true);
        startani = false;
    }

    public void ClearEvent()
    {
        Travelling_Panel2.SetActive(true);
    }

    public void GrabEvent()
    {
        Player_Animator.enabled = false;
    }


    public static void changeState(int state)
    {
       
            switch (state)
            {
                case STATE_READY:
                    Player_Animator.SetInteger("state", STATE_READY);
                    break;

                case STATE_START:
                    Player_Animator.SetInteger("state", STATE_START);
                    break;

                case STATE_CUSTOMIZE:
                    Player_Animator.SetInteger("state", STATE_CUSTOMIZE);
                    break;

                case STATE_CLEAR:
                    Player_Animator.SetInteger("state", STATE_CLEAR);
                    break;

                case STATE_LGRAB:
                    Player_Animator.SetInteger("state", STATE_LGRAB);
                    break;

                case STATE_IDLE:
                    Player_Animator.SetInteger("state", STATE_IDLE);
                    break;

                case STATE_RGRAB:
                    Player_Animator.SetInteger("state", STATE_RGRAB);
                    break;
        }

            currentAnimationState = state;
       
        
    }


}
