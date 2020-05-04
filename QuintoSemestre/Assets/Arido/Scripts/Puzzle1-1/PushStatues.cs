using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushStatues : MonoBehaviour
{
    public int indice;
    public int objetivo;
    public bool contou;
  
    public List<float> posicoes;

    Vector3 posicaoAtual;

    void Update()
    {
        transform.position = new Vector3(posicoes[indice], transform.position.y, transform.position.z);
        if (indice == objetivo && contou == false)
        {
            ControlPuzzle.contadorAcertos++;
            contou = true;
            Debug.Log("acertou" + ControlPuzzle.contadorAcertos);
        }
    }
   public void  MoreMove()
    {
        if (indice <= 9)
        {
            indice++;
            Debug.Log(indice);
        }
        else
        {
            indice = 9;
            Debug.Log("maximo");
        }
    }
    public void LessMove()
    {
        if (indice >= 0)
        {
            indice--;
            Debug.Log(indice);
        }
        else
        {
            indice = 0;
            Debug.Log("minimo");
        }
    }


}
