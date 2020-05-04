using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoFalso : MonoBehaviour
{
    public Vector3 caiu;
   
    Vector3 posicao;
    Player jogador;
   
    void Start()
    {
        posicao = transform.localPosition;
        jogador = GetComponent<Player>();
        
    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            posicao = Vector3.Lerp(posicao, caiu, 2 * Time.deltaTime);
            Debug.Log("bateu certo");
            
        }
        Debug.Log("bateu na" + col.collider.tag);
    }
    
}
