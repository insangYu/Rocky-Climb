using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamRotation : MonoBehaviour
{

    public GameObject beam;
    public float beam_speed = -3f;

    void Update()
    {
        beam.transform.Rotate(new Vector3(0, 0, beam_speed), Space.Self);
    }
}
