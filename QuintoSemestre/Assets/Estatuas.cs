using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject estatua1, estatua2, estatua3;
    public GameObject portaprincipal;
    public GameObject camera_porta;

    float contador;
    bool porta_desceu = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ganesha = estatua1.transform.eulerAngles.y;
        float ganesha1 = estatua2.transform.eulerAngles.y;
        float ganesha2 = estatua3.transform.eulerAngles.y;


        if ((ganesha <= 20f || ganesha >= 350f) && (ganesha1 >= 170f && ganesha1 <= 180f) && (ganesha2 >= 80f && ganesha2 <= 90f))
        {
            contador += Time.deltaTime * 2f;
            camera_porta.SetActive(true);
            print(contador);

            if (contador > 2f) { 
                portaprincipal.GetComponent<Interpolacao>().PortaPuzzle1();

                if (contador > 6f)
                {
                    camera_porta.SetActive(false);
                    //contador = 0;
                }
            }
        }
       
    }
}
