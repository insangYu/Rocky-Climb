using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    public Rigidbody2D player;
    public float m_rotationSpeed = 180f;

    public Vector3 m_HandToRoot;

    public GameObject perfect;

    void Update()
    {
        
        m_HandToRoot = this.transform.root.position - this.transform.position;

        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 50))
        {
            if (hitInfo.transform.gameObject.tag == "Gem_Rock")
            {
                Animator GemRock = hitInfo.transform.GetComponent<Animator>();

                if (Input.GetMouseButtonDown(0))
                {
                    soundManager.instance.soundGemCount();
                    GemManager.Gem++;
                    GemRock.SetInteger("state", 1);
                    if (QuestPanel.QuestNum == 3)
                    {
                        GemManager.QuestGem++;
                    }
                }
                
            }

            if (hitInfo.transform.gameObject.tag == "Last_Gem_Rock" || hitInfo.transform.gameObject.tag == "(cave)Last_Gem_Rock")
            {
                Animator GemRock = hitInfo.transform.GetComponent<Animator>();

                if (Input.GetMouseButtonDown(0))
                {
                    ClearAnimation.isClear = true;
                    ClearAnimation.isCaveClear = true;
                    GemManager.Gem++;
                    GemRock.SetInteger("state", 1);
                    soundManager.instance.soundGemCount();
                    ClearAnimation.MountainClimbed++;
                }
            }

            if (hitInfo.transform.gameObject.tag == "Rock" || hitInfo.transform.gameObject.tag == "Gem_Rock")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    
                    if(MapEvent.isCaveOn == false)
                    {
                        PlayerAnimation.Player_Animator.enabled = true;
                        if (Player.cnt % 2 == 1)
                        {
                            PlayerAnimation.changeState(4);
                        }

                        if (Player.cnt % 2 == 0)
                        {
                            PlayerAnimation.changeState(6);
                        }
                    }
                    if(MapEvent.isCaveOn == true)
                    {
                        if (Player.cnt % 2 == 1)
                        {
                            PlayerCaveAnimation.CavePlayer.SetInteger("state",4);
                        }

                        if (Player.cnt % 2 == 0)
                        {
                            PlayerCaveAnimation.CavePlayer.SetInteger("state", 5);
                        }
                    }
                    
                    
                    Vector3 target = hitInfo.transform.position;
                    Vector3 offset = target + m_HandToRoot;
                    
                    if (Vector3.Distance(hitInfo.transform.position, transform.position) <= 9.1010f && Player.cnt >= 1)
                    {
                        soundManager.instance.soundPerfectGrab();
                        PerfectGrab.perfectGrab++;
                        if(QuestPanel.QuestNum == 2)
                        {
                            PerfectGrab.Quest_PerfectGrab++;
                        }
                        Instantiate(perfect, hitInfo.transform.position, Quaternion.identity);
                        Score.score++;
                    }


                    transform.root.position = offset - new Vector3(0f, 0f, 9.1f);
                    hitInfo.transform.gameObject.tag = "rock";
                    
                }
            }

            if (hitInfo.transform.gameObject.tag == "coll" && Player.cnt >= 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Player.isPlay = false;
                    Score.score = Score.score - 1;
                    MapEvent.cameraFollow = false;
                }
            }
        }

    }

    
}
