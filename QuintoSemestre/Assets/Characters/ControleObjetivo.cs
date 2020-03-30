using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleObjetivo : MonoBehaviour
{
    [SerializeField] GameObject[] l_trigger;
    [SerializeField] Sprite[] l_objetivo;

    public AudioClip som;
    public int indice;
    AudioSource sons;    
    public GameObject objetivos;
    void Start()
    {
        indice = 0;
        sons = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        for ( int x = indice; indice < l_trigger.Length; indice++)
        {
         //   Debug.Log(indice);
         //  Debug.Log("bateu");
             l_trigger[indice].SetActive(false);
             objetivos.GetComponent<Image>().sprite = l_objetivo[indice];
             sons.clip = som;
            sons.Play();

            indice++;
            break;
        }
    }
}
