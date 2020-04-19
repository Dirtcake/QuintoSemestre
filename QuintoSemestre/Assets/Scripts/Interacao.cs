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

         
            if (Physics.Raycast(raio, out hit, distance)){
                selecao = hit.transform.GetComponent<Selecionavel>();
                ativacao = hit.transform.GetComponent<Ativavel>();
            }
       
       
        

        if (selecao != null){
            selecao.Selecionar();
        }

        if(ativacao != null){
            if (Input.GetMouseButtonDown(0)) {
                if(ativacao.controle_de_camera == true) copia = hit.transform.position;
                ativacao.Animacao();
                ativacao.Ativa();
            }
        }        
     }

    }

