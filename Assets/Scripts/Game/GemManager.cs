using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemManager : MonoBehaviour {

    public static int Gem = 0;
    public static int QuestGem = 0;

    public Text GemText;

	void Start ()
    {
		
	}

	void Update ()
    {
        GemText.text = "   X " + Gem;
    }
}
