using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Interactible : MonoBehaviour
{
    public float distance = 60;
    Vector3 copia = Vector3.zero;

    public GameObject Hud, aureaCalice;

    void Update()
    {
        //raycast 1
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);

        RaycastHit hit;
        Selecionavel selecao = null;
        Action ativacao = null;
        Puller puller = null;
        TacaSelecao taca = null;
        FinalCheck final = null;
        MangaVerde manga = null;
        GetPergaminho pergaminho = null;


        if (Physics.Raycast(raio, out hit, distance))
        {
            selecao = hit.transform.GetComponent<Selecionavel>();
            ativacao = hit.transform.GetComponent<Action>();
            puller = hit.transform.GetComponent<Puller>();
            taca = hit.transform.GetComponent<TacaSelecao>();
            final = hit.transform.GetComponent<FinalCheck>();
            manga = hit.transform.GetComponent<MangaVerde>();
            pergaminho = hit.transform.GetComponent<GetPergaminho>();

        }

        //Debug.Log(pergaminho);
        

        if (selecao != null)
        {
            selecao.Selecionar();
           if(Hud != null) Hud.SetActive(true);
        }
        else if (Hud != null) Hud.SetActive(false);

        if (puller != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                puller.Move();
            }
        }

        if (pergaminho != null)
        {
            if (Input.GetMouseButtonDown(0))
            {

                pergaminho.GetPintura();
            }
        }

        if (taca != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
               taca.coletaTaca();
            }
        }

        if (manga != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                manga.FINAL();
            }
        }
        if (final != null)
        {

            if (aureaCalice != null) aureaCalice.SetActive(true);


            if (Input.GetMouseButtonDown(0))
            {
                final.ProcessaFinal();
            }
        }
        else if (aureaCalice != null) aureaCalice.SetActive(false);

        if (ativacao != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ativacao.Ativa();
            }
        }
    }
}
