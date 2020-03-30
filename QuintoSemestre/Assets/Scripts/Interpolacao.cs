using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpolacao : MonoBehaviour
{
    public Vector3 controlador_estado_inicial;
    public Vector3 controlador_estado_final;

    public Vector3 controlado_estado_inicial;
    public Vector3 controlado_estado_final;


    bool alavanca_ativa = false;
    bool porta_ativa = false;
    bool estatua_ativa = false;
  
    void Update()
    {
        Quaternion posicao = transform.rotation;
        
        if(gameObject.tag == "alavanca") { 
            if (alavanca_ativa)
            {
                posicao = Quaternion.Slerp(posicao,Quaternion.Euler(controlador_estado_inicial), Time.deltaTime * 3);
                transform.rotation = posicao;
            }

            else if(!alavanca_ativa) {
                posicao = Quaternion.Slerp(posicao,Quaternion.Euler(controlador_estado_final), Time.deltaTime * 3);
                transform.rotation = posicao;
            }

        }

        if(gameObject.tag == "porta")
        {
            if (porta_ativa)
            {

            }

            else
            {

            }


        }

    }

    
    public void Porta()
    {
        porta_ativa = !porta_ativa;
    }

    public void Alavanca()
    {
        alavanca_ativa = !alavanca_ativa;
    }

    
}
