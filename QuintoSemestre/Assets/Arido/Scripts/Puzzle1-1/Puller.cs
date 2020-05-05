using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puller : MonoBehaviour
{
    public bool positivo;
    public PushStatues status;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (positivo == true)
            {
                status.MoreMove();
               // status.indice++;
                Debug.Log("subiu");
            }
            else
            {
                status.LessMove();
                status.indice--;
                Debug.Log("desceu");
            }
            Debug.Log("bateu errado");
        }
    }
}
