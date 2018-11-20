using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text ScoreText;
    public static int score = 0;
    public static int totalScore = 0;
    public static int highScore = 0;
    public static int temp = 0;

    void Awake()
    {
        
    }

    void Update()
    {
        ScoreText.text = "" + score;
        if(Player.isPlay == false)
        {
            ScoreText.gameObject.SetActive(false);
        }
    }

}
