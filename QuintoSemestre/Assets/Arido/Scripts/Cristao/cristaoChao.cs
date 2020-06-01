using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;

public class cristaoChao : MonoBehaviour
{

    public static bool errou_plataforma = false; 
    public int indice = 0;
    public GameObject porta, portaAberta;
    public GameObject[] plataformasObj;
    public String[] ordem_Correta_Plataformas;
   

    void Update()
    {
        if(errou_plataforma == true)
        {
            if (indice != 0)
            {
                Debug.Log("voltou" + indice);
                plataformasObj[indice].SetActive(true);
                indice--;
            }
            else if (indice >= 0)
            {
                Debug.Log("voltou" + indice);
                plataformasObj[indice].SetActive(true);
                errou_plataforma = false;
            }        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("plataforma"))
        {
            Debug.Log(other.name + other.tag);
            if (indice < plataformasObj.Length)
            {
                if ( other.name == ordem_Correta_Plataformas[indice] )
                {

                    Debug.Log("acertou");
                    indice++;
                    if (indice == 10)
                    {
                        Debug.Log("parabens krl ");
                        porta.SetActive(false);
                        portaAberta.SetActive(true);
                    }

                }
                else
                    errou_plataforma = true;
            }
        }
    }
}
