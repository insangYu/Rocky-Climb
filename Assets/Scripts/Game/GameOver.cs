using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public RestartPanel restartpanel;
    public LeavePanel leavepanel;
    public Rigidbody2D player;

    void Start()
    {

    }

    void Update()
    {
        
        if (Player.isPlay == false && MapEvent.isCaveOn == false && Player.cnt >= 1)
        {
            Invoke("gameOver", 2);
            player.gravityScale = 5;
        }
        else if (Player.isPlay == false && MapEvent.isCaveOn == true && Player.cnt >= 1)
        {
            Invoke("cavegameOver", 2);
            player.gravityScale = 5;
        }
    }

    void gameOver()
    {
        restartpanel.GameOver();
    }

    void cavegameOver()
    {
        leavepanel.CaveGameOver();
    }


}

