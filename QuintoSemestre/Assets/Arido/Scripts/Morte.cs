using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Morte : MonoBehaviour
{

    Vector3 checkpoint1;
    Quaternion rotacao_inicial;
    public Image morreu;

    bool morrendo;

    void Start()
    {
        checkpoint1 = transform.position;
        rotacao_inicial = transform.rotation;
    }

    
    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Morte_Trigger")
        {
            StartCoroutine(Morreu());
        }

    }

    IEnumerator Morreu()
    {
        if (!morrendo)
        {
            morrendo = true;

            Player.free = false;


            yield return new WaitForSeconds(1);

            //Cor
            Color cor = morreu.color;
            while (cor.a < 1 )
            {
                cor.a += Time.deltaTime * 2;
                morreu.color = cor;
                yield return null;
            }

            transform.position = checkpoint1;
            transform.rotation = rotacao_inicial;

            while (cor.a > 0)
            {
                cor.a -= Time.deltaTime * 2;
                morreu.color = cor;
                yield return null;
            }

            yield return new WaitForSeconds(1);


            Player.free = true;

            morrendo = false;
        }
    }
}
