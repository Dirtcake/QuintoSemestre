using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class SamsaraScript : MonoBehaviour
{
    public GameObject puzzle1Canva;
    public GameObject[] imagens;
    public Transform[] posicoes_atuais;
    public Vector3[] posicoes_iniciais;

    GameObject plataformasObjeto;
    GameObject jogador;
    HinduPuzzle habilitaCanvas;
    Vector3 posicao;
    Quaternion rot;
   // GameObject pai;
    Button filho;
   // string nomeBotao;
    public int clique = 1;
    public int contadorAcertos = 0;
    public bool concluido;

    void Start()
    {
        jogador = GameObject.Find("Player");
        plataformasObjeto = GameObject.Find("Plataformas");

        habilitaCanvas = jogador.GetComponent<HinduPuzzle>();
        //Posicoes Iniciais;
        for (int b = 0; b < posicoes_atuais.Length; b++)
        {
            posicoes_iniciais[b] = posicoes_atuais[b].position;
            print(posicoes_iniciais[b]);
        }

        puzzle1Canva.SetActive(false);

    }


    void Update()
    {

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 60);

        RaycastHit hit;

        if (Physics.Raycast(raio, out hit, 60))
        {
            if (Input.GetMouseButtonDown(0))
            {
                //SetaPosicao(hit.transform.gameObject);
            }

        }
    
        if (concluido)
        {
            plataformasObjeto.GetComponent<Interpolacao>().enabled = true;
            habilitaCanvas.canvaPuzzle1 = false;
        }

       
    }
    Vector3 pos1, pos2;
    Quaternion rot1, rot2;
    GameObject copiaPeca;
    //void SetaPosicao(GameObject peca)
    //{
    //    if(clique == 1)
    //    {
    //        copiaPeca = peca;
    //        pos1 = peca.transform.position;
    //        rot1 = peca.transform.rotation;
    //        peca.transform.SetPositionAndRotation(new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
    //        print(pos1 + " " + rot1);
    //        clique++;
    //    }

    //    else if(clique == 2)
    //    {
    //        peca.transform.SetPositionAndRotation(pos1,rot1);

    //        clique = 1;
    //    }
        //

    //}


   
    public void Imprimir(Button buton)
    {
        if(clique == 1)
        {
            filho = buton.GetComponent<Button>();
            //print(filho.name);
            clique++;
        }
        else if (clique == 2)
        {
            //guarda a posic
            posicao = buton.transform.position;
            rot = buton.transform.rotation;

            buton.transform.SetPositionAndRotation(filho.transform.position, filho.transform.rotation);
            filho.transform.SetPositionAndRotation(posicao, rot);
            for(int i = 0; i < posicoes_iniciais.Length; i++) {
                if (imagens[i].transform.position == posicoes_iniciais[i]) contadorAcertos++;
                else contadorAcertos = 0;
            }

            if (contadorAcertos >= posicoes_iniciais.Length) concluido = true;
            else concluido = false;
            
            clique = 1;
        }
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
