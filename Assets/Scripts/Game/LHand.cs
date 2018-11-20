using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHand : HandManager
{

    void FixedUpdate()
    {
        if (Player.isPlay == true && ClearAnimation.isClear == false)
        {
            leftRotate();
        }
    }

    void leftRotate()
    {
        if (Player.cnt % 2 == 1)
        {
            player.transform.RotateAround(transform.position, Vector3.forward, m_rotationSpeed * Time.deltaTime);
        }
    }


}
