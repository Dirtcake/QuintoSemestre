using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCheck : MonoBehaviour
{
    public GameObject tacasAurea,calices,animaFinal,triggerFinal;
    public void ProcessaFinal()
    {
        if(HubSpawnManager.indice != 3)
        {
            Debug.Log("Ainda não");
        }
        else
        {
            triggerFinal.SetActive(true);
            Instantiate(animaFinal);
            calices.SetActive(true);
            Destroy(tacasAurea);
        }

    }
}
