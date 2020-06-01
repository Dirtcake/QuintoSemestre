using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;

public class cristaoChao : MonoBehaviour
{

    public bool errou_plataforma = false; 
    public int indice = 0;
    public GameObject porta;
    public GameObject[] plataformasObj;
    public String[] ordem_Correta_Plataformas;
    MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }
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
                    plataformasObj[indice].SetActive(false);
                    Debug.Log("acertou");
                    indice++;
                    if (indice == 10)
                    {
                        Debug.Log("parabens krl ");
                        porta.SetActive(false);
                    }

                }
                else
                    errou_plataforma = true;
            }
        }
    }
}
