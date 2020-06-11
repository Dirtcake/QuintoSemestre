using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPergaminho : MonoBehaviour
{
    GameObject Spawn;
    public int indice;
    private void Start()
    {
        Spawn = GameObject.Find("Spawn");
    }
    public void GetPintura()
    {

        Debug.Log("pegou");
        Spawn.GetComponent<HubSpawnManager>().liberarPergaminho(indice);
        Destroy(this);
    }
}
