using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleMandamentos : MonoBehaviour
{
    public GameObject[] mandamentos;
    public GameObject[] localizacaoObjetivo;
    public GameObject porta;
    public int indice;
    public int objetivo;
    public int acertos;
    public static bool arrastando;
    public float distMin;
    public float dist;
    public GameObject panel;

    void Update()
    {
        dist = Vector3.Distance(mandamentos[indice].transform.position, localizacaoObjetivo[indice].transform.position);

       
        if (dist <= distMin)
        {
            arrastando = true;
            acertou();
        }
        else
        {
            Debug.Log("longe" + dist);
        }
        #region acertos
        if (acertos == 1)
        {
            localizacaoObjetivo[0].transform.position = mandamentos[0].transform.position;
            arrastando = false;
        }
        if (acertos == 2)
        {
            localizacaoObjetivo[1].transform.position = mandamentos[1].transform.position;
            arrastando = false;
        }
        if (acertos == 3)
        {
            localizacaoObjetivo[2].transform.position = mandamentos[2].transform.position;
            arrastando = false;
        }
        if (acertos == 4)
        {
            localizacaoObjetivo[3].transform.position = mandamentos[3].transform.position;
            arrastando = false;
        }
        if (acertos == 5)
        {
            localizacaoObjetivo[4].transform.position = mandamentos[4].transform.position;
            arrastando = false;
        }
        if (acertos == 6)
        {
            localizacaoObjetivo[5].transform.position = mandamentos[5].transform.position;
            arrastando = false;
        }
        if (acertos == 7)
        {
            localizacaoObjetivo[6].transform.position = mandamentos[6].transform.position;
            arrastando = false;
        }
        if (acertos == 8)
        {
            localizacaoObjetivo[7].transform.position = mandamentos[7].transform.position;
            arrastando = false;
        }
        if (acertos == 9)
        {
            localizacaoObjetivo[8].transform.position = mandamentos[8].transform.position;
            arrastando = false;
        }
        if (acertos == 10)
        {
          //  localizacaoObjetivo[9].transform.position = mandamentos[9].transform.position;
            porta.SetActive(false);
            panel.SetActive(false);
            Debug.Log("foi");
        }
          
        #endregion

    }
    public void acertou()
    {
        mandamentos[indice].SetActive(false);
        indice++;
        acertos++;   
    }
}
