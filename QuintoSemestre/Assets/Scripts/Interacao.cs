using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour
{
    public float distance = 10;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //laser cast AMANDA 
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * distance);
        RaycastHit hit;
        Selecionavel selecao = null;


        if (Physics.Raycast(raio, out hit, distance)){
            selecao = hit.transform.GetComponent<Selecionavel>();
        }
        if(selecao != null){
            selecao.Selecionar();
        }

        

    }
}
