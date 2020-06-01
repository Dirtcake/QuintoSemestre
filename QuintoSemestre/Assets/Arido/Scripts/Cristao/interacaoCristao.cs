using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacaoCristao : MonoBehaviour
{
    public float distance = 60;
    public string nomeObjeto;
    public GameObject panel;
    void Update()
    {
        
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);

        RaycastHit hit;
        if (Physics.Raycast(raio, out hit, distance))
        {

            if (Input.GetMouseButtonDown(0))
            {
                if(nomeObjeto == hit.transform.name)
                {
                    panel.SetActive(true);
                }
            }

        }
    }
}
