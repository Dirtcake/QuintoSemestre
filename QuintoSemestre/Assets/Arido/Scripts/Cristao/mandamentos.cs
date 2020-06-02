using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mandamentos : MonoBehaviour
{
    public GameObject objetivo;
    public float dist, distMin;
    public int ponto = 1;

    void Update()
    {
        dist = Vector3.Distance(transform.position, objetivo.transform.position);
        
        if (dist <= distMin)
        {
            transform.position = objetivo.transform.position;
            if(ponto >= 1)
            {
                controleMandamentos.acertos++;
                ponto--;
            }
        }
    }
}
