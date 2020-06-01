using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class HinduPuzzle : MonoBehaviour
{
    //public Canvas puzzle1;
    public GameObject plataformas_Obj;
    public GameObject puzzle1UI;
    public String[] plataformas;
    public bool errou_plataforma = false;
    public String[] ordem_Correta_Plataformas = { "Plataforma1", "Plataforma2", "Plataforma3", "Plataforma4", "Plataforma5" };
    int i = 0;
    float tempo;
    public bool canvaPuzzle1;

    
    
    void Start()
    {
        plataformas = new string [5];  
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GetComponentInChildren<Interacao>().nomeObjeto == "RODASAMSARA")
        {
            canvaPuzzle1 = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            canvaPuzzle1 = false;
        }

        if (canvaPuzzle1)
        {
            puzzle1UI.SetActive(true);
        }
        else if(!canvaPuzzle1) puzzle1UI.SetActive(false);

        #region PUZZLE 2
        //print(tempo);

        if (errou_plataforma == true && tempo <= 4f)
        {
            tempo += Time.deltaTime;
        }
        else if(tempo > 4f)
        {
            errou_plataforma = false;
            tempo = 0;
        }
        #endregion
    }
    
    //PUZZLE PARTE 2
    void OnCollisionEnter(Collision collision)
    {
       
        if(i < plataformas.Length) { 
            if(!errou_plataforma) plataformas[i] = collision.transform.name;

            if (plataformas[i] != ordem_Correta_Plataformas[i]) {

                errou_plataforma = true;
                while (i>= 0){ 
                    plataformas[i] = null; 
                    i--;
                }
            } 
            i++;
        }
    }

    public void ImprimeNome()
    {
        print(gameObject.name);
        
    }

}
