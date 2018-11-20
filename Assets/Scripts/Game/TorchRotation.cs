using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchRotation : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;


    public float rotateSpeed1 = -1f;
    public float rotateSpeed2 = 1f;


    void Start()
    {

    }

    void Update()
    {
        light1.transform.Rotate(new Vector3(0, 0, rotateSpeed1), Space.Self);
        light2.transform.Rotate(new Vector3(0, 0, rotateSpeed2), Space.Self);
    }
}
