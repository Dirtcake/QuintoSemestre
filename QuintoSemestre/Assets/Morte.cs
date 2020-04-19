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

    // Start is called before the first frame update
    void Start()
    {
        
        checkpoint1 = transform.position;
        rotacao_inicial = transform.rotation;
    }

    // Update is called once per frame
    
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

            GetComponent<FirstPersonController>().pj_andando = false;
            GetComponent<CharacterController>().enabled = false;

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

            GetComponent<FirstPersonController>().pj_andando = true;
            GetComponent<CharacterController>().enabled = true;

            morrendo = false;
        }
    }
}
