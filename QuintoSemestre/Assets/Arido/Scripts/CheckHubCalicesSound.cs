using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHubCalicesSound : MonoBehaviour
{

    void Update()
    {
        if(HubSpawnManager.hubCalicesSom != 0)
        {
            Destroy(gameObject);
        } 


    }

    private void OnDestroy()
    {
        HubSpawnManager.hubCalicesSom++;
    }
}
