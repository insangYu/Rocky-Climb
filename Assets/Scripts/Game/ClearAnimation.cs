using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAnimation : MonoBehaviour
{

    public Animator GemRock_Animation;
    public static bool isClear;
    public static bool isCaveClear;
    public static int MountainClimbed = 0;

    void Start()
    {
        isClear = false;
        GemRock_Animation = this.GetComponent<Animator>();
    }


}
