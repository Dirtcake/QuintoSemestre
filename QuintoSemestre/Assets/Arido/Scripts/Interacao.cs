using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour
{
    public float distance = 60;
    Vector3 copia = Vector3.zero;
    
    void Update()
    {
        //raycast 1
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);
       
        RaycastHit hit;
        Selecionavel selecao = null;
        Ativavel ativacao = null;
        Puller controle = null;

         
            if (Physics.Raycast(raio, out hit, distance)){
                selecao = hit.transform.GetComponent<Selecionavel>();
                ativacao = hit.transform.GetComponent<Ativavel>();

                controle = hit.transform.GetComponent<Puller>();
            }

        if (controle != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("deveria mexer");
               
            }
            Debug.Log("achou caralho");
        }


        if (selecao != null){
            selecao.Selecionar();
        }

        if(ativacao != null){
            if (Input.GetMouseButtonDown(0))
            {
                //Guardando lógica para posteriores correções
                if(ativacao.controle_de_camera == true) copia = hit.transform.position;

                if (!ativacao.ativo)
                {
                    ativacao.Animacao();
                    ativacao.Ativa();
                }
            }
        }        
     }

    }

