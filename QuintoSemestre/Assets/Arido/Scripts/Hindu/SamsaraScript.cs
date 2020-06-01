using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class SamsaraScript : MonoBehaviour
{

    public GameObject[] imagens;
    public Transform[] posicoes_atuais;
    public Vector3[] posicoes_iniciais;

    GameObject plataformasObjeto;
    GameObject jogador;

    Vector3 pos1, pos2;
    Quaternion rot1, rot2;
    GameObject copiaPeca;

    public int clique = 1;
    public int contadorAcertos = 0;
    public bool concluido;
    bool animacao;

    void Start()
    {
        jogador = GameObject.Find("Player");
        plataformasObjeto = GameObject.Find("Plataformas");

        //Posicoes Iniciais;
        for (int b = 0; b < posicoes_atuais.Length; b++)
        {
            posicoes_iniciais[b] = posicoes_atuais[b].position;
            print(posicoes_iniciais[b]);
        }

    }


    void Update()
    {

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 60);

        RaycastHit hit;

        if (Physics.Raycast(raio, out hit, 60))
        {
            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "samsara")
            {
                SetaPosicao(hit.transform.gameObject);
            }

        }
    
        if (concluido)
        {
            plataformasObjeto.GetComponent<Interpolacao>().enabled = true;
            
        }

       
    }
   
    void SetaPosicao(GameObject peca)
    {
        if (clique == 1)
        {
            copiaPeca = peca;
            pos1 = peca.transform.position;
            rot1 = peca.transform.rotation;

            clique++;
        }

        else if (clique == 2)
        {
            pos2 = peca.transform.position;
            rot2 = peca.transform.rotation;

                //peca.transform.position = Vector3.MoveTowards(peca.transform.position, pos1, Time.deltaTime);
                //peca.transform.rotation = Quaternion.Slerp(peca.transform.rotation, rot1, Time.deltaTime);
                peca.transform.SetPositionAndRotation(pos1, rot1);
                copiaPeca.transform.SetPositionAndRotation(pos2, rot2);

                for (int i = 0; i < posicoes_iniciais.Length; i++)
                {
                    if (imagens[i].transform.position == posicoes_iniciais[i]) contadorAcertos++;
                    else contadorAcertos = 0;
                }

                if (contadorAcertos >= posicoes_iniciais.Length) concluido = true;
                else concluido = false;
                       clique = 1;

            #region logicas
            //posicao = buton.transform.position;
            //rot = buton.transform.rotation;
            //transform.SetPositionAndRotation()
            //print(posicao + ", " + rot);

            //PERFECT
            //print(buton.transform.parent.name);
            //foreach (Button imagens in transform)
            //{
            //}
            //
            //nomeBotao = buton.name;
            //pai = GameObject.Find(buton.transform.parent.name);
            //print(pai.name);
            //print(pai.transform.childCount);
            //print(buton.name);
            #endregion

        }
    }
}
