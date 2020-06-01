using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controleMandamentos : MonoBehaviour
{
    public GameObject[] mandamentos;
    public GameObject panel;
    public GameObject porta, portaAberta;
    public static int indice;
    public int objetivo;
    public static int acertos;
    public static bool arrastando;
    public float distMin;
    public float dist;
    public GameObject[] localizacaoObjetivo;
    public Text teste;

    void Update()
    { 
        dist = Vector3.Distance(mandamentos[indice].transform.position, localizacaoObjetivo[indice].transform.position);
        teste.text = acertos.ToString();
          if (dist <= distMin)
          {
              arrastando = true;
          }
          else
              Debug.Log("longe" + dist);
          
          if (acertos == 1)
          {
              arrastando = false;
            Debug.Log("voltou");
          }
          if (acertos == 2)
              arrastando = false;

          if (acertos == 3)
              arrastando = false;

          if (acertos == 4)
              arrastando = false;

          if (acertos == 5)
              arrastando = false;

          if (acertos == 6)
              arrastando = false;

          if (acertos == 7)
              arrastando = false;

          if (acertos == 8)
              arrastando = false;

          if (acertos == 9)
            arrastando = false;
            
        if (acertos == 10 || indice == 9)
        {
            arrastando = false;
            porta.SetActive(false);
            portaAberta.SetActive(true);
            panel.SetActive(false);
            Debug.Log("foi");
        }     
    }
}

