using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolacao : MonoBehaviour
{
    public Vector3 controlado_estado_inicial;
    public Vector3 controlado_estado_final;

    public float velocidade_anim = 2;
    private float contador = 0;
    public float angulo;

    bool porta_ativa = false;
    bool estatua_ativa = false;
    bool portapuzzle1 = false;

    void Update()
    {
        Quaternion rotacao = transform.rotation;
        Vector3 posicao = transform.localPosition;

        if (gameObject.tag == "porta")
        {
            if (porta_ativa)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                posicao = Vector3.Lerp(posicao, controlado_estado_final, Time.deltaTime * velocidade_anim);
            }           
        }

        if(gameObject.tag == "estatua")
        {
            //Quaternion quat = Quaternion.Euler(rotacao.x, rotacao.y, rotacao.z);
            rotacao = Quaternion.Lerp(rotacao, Quaternion.AngleAxis(angulo * contador, Vector3.up), Time.deltaTime * velocidade_anim);
        }

        if(gameObject.name == "PortaPuzzle1")
        {
            if (portapuzzle1)
            {
                //gameObject.GetComponent<BoxCollider>().enabled = false;
                
                posicao = Vector3.Lerp(posicao, controlado_estado_final, Time.deltaTime * velocidade_anim);
            }
        }

        transform.rotation = rotacao;
        transform.localPosition = posicao;
    }

    
    public void Porta()
    {
        porta_ativa = true;
    }

    public void Estatua()
    {
        contador += 1;
    }

    public void PortaPuzzle1()
    {
        portapuzzle1 = !portapuzzle1;
    }

    



}
