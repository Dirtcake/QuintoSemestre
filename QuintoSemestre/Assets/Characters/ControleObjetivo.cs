using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleObjetivo : MonoBehaviour
{
    [SerializeField] GameObject[] l_trigger;
    [SerializeField] Sprite[] l_objetivo;

    public int indice;
    void Start()
    {
        indice = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        for ( int x = indice; indice < l_trigger.Length; indice++)
        {
            Debug.Log(indice);
            Debug.Log("bateu");

            l_trigger[indice].SetActive(false);


            indice++;
            break;
        }
    }
}
