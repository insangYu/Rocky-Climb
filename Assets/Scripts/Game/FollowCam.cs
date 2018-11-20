using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public GameObject player;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Player.isPlay == true || MapEvent.cameraFollow == true)
        {
            Camera.main.transform.position = player.transform.position - new Vector3(0, 0, 20f);
        }
    }

}
