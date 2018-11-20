using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimation : MonoBehaviour
{
    //private static BoxAnimation s_Instance;
    //public static BoxAnimation Instance
    //{
    //    get
    //    {
    //        return s_Instance;
    //    }
    //}
    

    public static Animator Box_Animator;
    public static int Breakcnt = 0;

    const int BOX_IDLE = 0;
    const int BOX_CLICK1 = 1;
    const int BOX_CLICK2 = 2;
    const int BOX_OPEN = 3;

    void Awake()
    {
        //// 이미만들어진 객체가 있으면 자가 삭제
        //if (s_Instance != null)
        //{
        //    DestroyObject(this);
        //    return;
        //}

        //s_Instance = this;
    }

    void Start()
    {
        Box_Animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        
        if (StartPanel.isGiftOn == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Breakcnt++;
            }

        }

        switch (Breakcnt)
        {
            case BOX_IDLE:
                changeState(BOX_IDLE);
                break;

            case BOX_CLICK1:
                changeState(BOX_CLICK1);
                break;

            case BOX_CLICK2:
                changeState(BOX_CLICK2); 
                break;

            case BOX_OPEN:
                changeState(BOX_OPEN); 
                break;
        }

    }

    public static void changeState(int click)
    {
        switch (click)
        {
            case  BOX_IDLE:
                Box_Animator.SetInteger("click", BOX_IDLE);
                break;

            case BOX_CLICK1:
                Box_Animator.SetInteger("click", BOX_CLICK1);
                break;

            case BOX_CLICK2:
                Box_Animator.SetInteger("click", BOX_CLICK2);
                break;

            case BOX_OPEN:
                Box_Animator.SetInteger("click", BOX_OPEN);
                StartPanel.isGiftOn = false;
                break;
        }

    }

    public void addGemEvent()
    {
        GemManager.Gem += 137;
    }

}
