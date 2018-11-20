using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RHand : HandManager
{
    void FixedUpdate()
    {
        if (Player.isPlay == true && ClearAnimation.isClear == false )
        {
            rightRotate();
        }
    }



    void rightRotate()
    {
        if (Player.cnt % 2 == 0)
        {
            player.transform.RotateAround(transform.position, Vector3.back, m_rotationSpeed * Time.deltaTime);
        }
    }
}
