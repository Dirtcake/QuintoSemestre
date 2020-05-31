using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour
{
    public float distance = 60;
    Vector3 copia = Vector3.zero;
    public string nomeObjeto;
    public GameObject Hud;

    void Update()
    {
        //raycast 1
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);
       
        RaycastHit hit;
        Selecionavel selecao = null;
        Ativavel ativacao = null;
        Action acao = null;


        if (Physics.Raycast(raio, out hit, distance)){
                selecao = hit.transform.GetComponent<Selecionavel>();
                ativacao = hit.transform.GetComponent<Ativavel>();
                acao = hit.transform.GetComponent<Action>();

            if (Input.GetMouseButtonDown(0))
                {
                    nomeObjeto = hit.transform.name;
                }

            }
       
       
        

        if (selecao != null){
            selecao.Selecionar();
            if (Hud != null) Hud.SetActive(true);

        }
        else if (Hud != null) Hud.SetActive(false);

        if (ativacao != null){
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
        if (acao != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                acao.Ativa();
            }
        }
    }

    }

