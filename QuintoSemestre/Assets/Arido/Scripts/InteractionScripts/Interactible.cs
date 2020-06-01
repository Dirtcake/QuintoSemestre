using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Interactible : MonoBehaviour
{
    public float distance = 60;
    Vector3 copia = Vector3.zero;

    public GameObject Hud;

    void Update()
    {
        //raycast 1
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);

        RaycastHit hit;
        Selecionavel selecao = null;
        Action ativacao = null;
        Puller puller = null;


        if (Physics.Raycast(raio, out hit, distance))
        {
            selecao = hit.transform.GetComponent<Selecionavel>();
            ativacao = hit.transform.GetComponent<Action>();
            puller = hit.transform.GetComponent<Puller>();

        }

        //Debug.Log(taca);
        

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

        if (ativacao != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ativacao.Ativa();
            }
        }
    }
}
