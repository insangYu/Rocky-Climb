using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeavePanel : CaveTime
{

    public GameObject leavePanel;

    public Button leaveButton;
    public Button restartButton;

    public Text CaveTime;

    void Start()
    {

    }

    void Update()
    {
        CaveTime.text = "" + _caveTimer;
    }

    public void LeaveButton()
    {
        MapEvent.isCaveOn = false;
        SceneManager.LoadScene("Mountain1");
        PlayerAnimation.Player_Animator.enabled = true;
        soundManager.instance.soundClick();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("CaveScene");
        soundManager.instance.soundClick();
    }

    public void CaveGameOver()
    {
        leavePanel.SetActive(true);
        Player.cnt = 0;
        Score.score = 0;
    }
}
