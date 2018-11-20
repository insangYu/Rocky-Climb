using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public AudioClip sound_Grab; 
    public AudioClip sound_PerfectGrab;
    public AudioClip sound_GemCount;
    public AudioClip sound_Click;
    public AudioClip sound_Fall;
    public AudioClip sound_Appear;

    AudioSource myAudio; 

    public static soundManager instance;  

    void Awake() 
    {
        if (soundManager.instance == null) 
        {
            soundManager.instance = this; 
        }
    }
    void Start()
    {
        myAudio = gameObject.GetComponent<AudioSource>();
    }

    public void soundGrab()
    {
        myAudio.PlayOneShot(sound_Grab);
    }

    public void soundPerfectGrab()
    {
        myAudio.PlayOneShot(sound_PerfectGrab);
    }

    public void soundGemCount()
    {
        myAudio.PlayOneShot(sound_GemCount);
    }

    public void soundOff()
    {
        myAudio.volume = 0;
    }

    public void soundOn()
    {
        myAudio.volume = 1;
    }

    public void soundClick()
    {
        myAudio.PlayOneShot(sound_Click);
    }

    public void soundFall()
    {
        myAudio.PlayOneShot(sound_Fall);
    }

    public void soundAppear()
    {
        myAudio.PlayOneShot(sound_Appear);
    }
}
