using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativavel : MonoBehaviour
{
    public GameObject controlado;
    public GameObject controlador;

    //Interpolacao ativado = GetComponent<Interpolacao>();

    public void Start()
    {
        
    }
   

    public void Ativa()
    {
        //ativado = GetComponent<Interpolacao>();

        if (gameObject.tag == "alavanca")
        {
            controlador.GetComponent<Interpolacao>().Alavanca();
            controlado.GetComponent<Interpolacao>();
        }


        if(gameObject.tag == "porta")
        {
            controlado.GetComponent<Interpolacao>().Porta();
        }

    }

    void Update()
    {
        
    }


}