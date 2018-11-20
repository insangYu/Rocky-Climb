using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusDrawer : MonoBehaviour
{

    public float m_Radius = 5.04f;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(this.transform.position, m_Radius);
    }


}
