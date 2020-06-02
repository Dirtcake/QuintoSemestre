using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PushStatues : MonoBehaviour
{
    public int indice;
    public int objetivo;
    public bool contou;
  
    public List<float> posicoes;

    Vector3 localObjetivo;

    void Update()
    {
        localObjetivo = new Vector3(posicoes[indice], transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position,localObjetivo,Time.deltaTime);


        if (indice == objetivo && contou == false)
        {
            ControlPuzzle.contadorAcertos++;
            contou = true;
            Debug.Log("acertou" + ControlPuzzle.contadorAcertos);
        }
    }
   public void  MoreMove()
    {
        if (transform.position.x > localObjetivo.x - 1 && transform.position.x < localObjetivo.x + 1)
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
    }
    public void LessMove()
    {
        if (transform.position.x > localObjetivo.x - 1 && transform.position.x < localObjetivo.x + 1)
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
}
