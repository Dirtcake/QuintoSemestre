using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuzzle : MonoBehaviour
{
    public static int contadorAcertos;
    public GameObject porta;
    void Update()
    {
        if(contadorAcertos >= 5)
        {
            porta.SetActive(false);
            Debug.Log("abriu");
        }
    }
}
