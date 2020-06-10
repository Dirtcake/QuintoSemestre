using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuzzle : MonoBehaviour
{
    public static int contadorAcertos;
    public GameObject portaAberta,portaFechada,animacao;
    void Update()
    {
        if(contadorAcertos >= 7)
        {
            portaAberta.SetActive(true);
            portaFechada.SetActive(false);
            Instantiate(animacao);
            Destroy(this);
        }
    }
}
