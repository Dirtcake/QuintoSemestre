using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MedidorAgua : MonoBehaviour
{
    public Slider barra;
    public float maximo;
     
    private void start(){
        barra.minValue = 0;
        barra.maxValue = maximo;
        barra.value = maximo;

    }
}
