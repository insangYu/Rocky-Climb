using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestPanel : MonoBehaviour
{

    public GameObject Quest_Panel;
    public Button quitButton;
    public Text Quest_Name;
    public Text Contents;
    public Text Progress;
 

    public static int QuestNum = 1;

    void Start()
    {

    }

    void Update()
    {
        switch (QuestNum)
        {
            case 1:
                Quest_Name.text = "QUEST " + QuestNum + " / 5";
                Contents.text = "GET 100 SCORE!";
                Progress.text = "PROGRESS : " + Score.totalScore + " / 100";
                if (Score.totalScore >= 100)
                {
                    QuestNum = 2;
                    Score.totalScore = 0;
                }
                break;

            case 2:
                Quest_Name.text = "QUEST " + QuestNum + " / 5";
                Contents.text = "10 PERFECT GRABS!";
                Progress.text = "PROGRESS : " + PerfectGrab.Quest_PerfectGrab + " / 10";
                if(PerfectGrab.Quest_PerfectGrab >= 10)
                {
                    QuestNum = 3;
                    PerfectGrab.Quest_PerfectGrab = 0;
                }
                break;

            case 3:
                Quest_Name.text = "QUEST " + QuestNum + " / 5";
                Contents.text = "GRAB 5 GEMS!";
                Progress.text = "PROGRESS : " + GemManager.QuestGem + " / 5";
                if(GemManager.QuestGem >= 5)
                {
                    QuestNum = 4;
                    GemManager.QuestGem = 0;
                }
                break;

            case 4:
                Quest_Name.text = "QUEST " + QuestNum + " / 5";
                Contents.text = "PASS 5 CHECKPOINTS!";
                Progress.text = "PROGRESS : ";
                break;

            case 5:
                Quest_Name.text = "QUEST " + QuestNum + " / 5";
                Contents.text = "CLIMB 100 METERS!";
                Progress.text = "PROGRESS : ";
                break;
        }

    }

    public void QuitButton()
    {
        Quest_Panel.SetActive(false);
        soundManager.instance.soundClick();
    }

}
