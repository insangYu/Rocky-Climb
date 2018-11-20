using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartPanel : MonoBehaviour
{

    public GameObject Restart_Panel;
    public GameObject Start_Panel;

    public Button RestartButton;
    public Button rankButton;
    public Button shareButton;
    public Button getGemButton;

    public Text Contents;
    public Text Progress;
    public Text highScore;

    public QuestPanel _QP;


    void Update()
    {

        switch(QuestPanel.QuestNum)
        {
            case 1:
                Contents.text = "GET 100 SCORE!";
                Progress.text = Score.totalScore + " / 100";
                break;

            case 2:
                Contents.text = "10 PERFECT GRABS!";
                Progress.text = PerfectGrab.Quest_PerfectGrab + " / 10";
                break;
            case 3:
                Contents.text = "GRAB 5 GEMS!";
                Progress.text = GemManager.QuestGem + " / 5 ";
                break;
            case 4:
                Contents.text = "PASS 5 CHECKPOINTS!";
                Progress.text = "PROGRESS : ";
                break;
            case 5:
                Contents.text = "CLIMB 100 METERS!";
                Progress.text = "PROGRESS : ";
                break;
        }
        highScore.text = "" + Score.highScore;

    }

    public void Restart_M1()
    {
        Restart_Panel.SetActive(false);
        SceneManager.LoadScene("Mountain1");
        soundManager.instance.soundClick();
    }

    public void RankButton()
    {
        soundManager.instance.soundClick();
    }

    public void ShareButton()
    {
        soundManager.instance.soundClick();
    }

    public void GetGemButton()
    {
        soundManager.instance.soundClick();
    }

    public void GameOver()
    {
        Restart_Panel.SetActive(true);
        Score.totalScore += Score.score;
        if(Score.temp > Score.highScore)
        {
            Score.highScore = Score.temp;
        }
        Score.temp = Score.score;
        Score.score = 0;
        Player.cnt = 0;
        
    }

}
