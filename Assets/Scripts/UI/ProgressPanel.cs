using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressPanel : MonoBehaviour
{
    public GameObject Progress_Panel;
    public GameObject beam;
    public GameObject Gem;

    public float beam_speed = -1f;

    public Text high_score;
    public Text m_perfectGrab;
    public Text mountain_climbed;

    public Button backButton;

    public void BackButton()
    {
        Progress_Panel.SetActive(false);
        Gem.SetActive(true);
        soundManager.instance.soundClick();
    }

    void Update()
    {
        beam.transform.Rotate(new Vector3(0, 0, beam_speed), Space.Self);

        high_score.text = "" + Score.highScore;
        m_perfectGrab.text = "" + PerfectGrab.perfectGrab;
        mountain_climbed.text = "" + ClearAnimation.MountainClimbed;
    }

}
