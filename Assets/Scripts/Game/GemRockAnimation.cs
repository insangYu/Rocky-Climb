using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRockAnimation : MonoBehaviour
{

    public Animator GemRock_Animation;

    void Start()
    {
        GemRock_Animation = this.GetComponent<Animator>(); 
    }


}
