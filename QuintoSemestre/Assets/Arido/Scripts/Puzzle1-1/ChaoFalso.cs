using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoFalso : MonoBehaviour
{
    public Vector3 caiu;
    Vector3 posicao;
    void Start()
    {
        posicao = transform.localPosition;
    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collider col)
    {
        if (CompareTag("Player"))
        {
            
            posicao = Vector3.Lerp(posicao, caiu, 2 * Time.deltaTime);
            
        }
    }
}
