using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTaca : MonoBehaviour
{
    public GameObject hud_taca;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            hud_taca.SetActive(true);
        }
    }
}
