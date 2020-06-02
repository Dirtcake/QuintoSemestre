using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacaSelecao : MonoBehaviour
{
   public void coletaTaca()
    {
        GameObject.FindGameObjectWithTag("taca").GetComponent<HubSpawnManager>().mostrarHud();

        Destroy(gameObject);
    }
}
