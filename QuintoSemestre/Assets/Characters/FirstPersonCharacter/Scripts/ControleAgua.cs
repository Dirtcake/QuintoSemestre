using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleAgua : MonoBehaviour
{
    public Slider Barra;

    public float maximo = 100f;
    void Start()
    {
        Barra.minValue = 0;
        Barra.maxValue = maximo;
        Barra.value = maximo;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
