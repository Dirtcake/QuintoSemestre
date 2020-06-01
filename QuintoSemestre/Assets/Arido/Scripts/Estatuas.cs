using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject estatua1, estatua2, estatua3;
    //public GameObject portaprincipal;
    //public GameObject camera_porta;

    public GameObject animacaoFinal, portaAberta, portaFechada,cameraPanoramica;

    float contador;
    bool porta_desceu = false;

    void Update()
    {
        float ganesha = estatua1.transform.eulerAngles.y;
        float ganesha1 = estatua2.transform.eulerAngles.y;
        float ganesha2 = estatua3.transform.eulerAngles.y;

        if ((ganesha > 89 && ganesha < 91) && (ganesha1 > 269 && ganesha1 < 271) && (ganesha2 > 179 && ganesha2 < 181))
        {
            cameraPanoramica.SetActive(false);
            Instantiate(animacaoFinal);
            portaAberta.SetActive(false);
            portaFechada.SetActive(true);
            Player.free = true;
            tutoHud.hudTuto = false;

            Destroy(this);

            /*if (!porta_desceu) contador += Time.deltaTime * 2f;
            camera_porta.SetActive(true);
            print(contador);

            if (contador > 2f) {
                portaprincipal.GetComponent<Interpolacao>().PortaPuzzle1();

                if (contador > 6f)
                {
                    porta_desceu = true;
                    camera_porta.SetActive(false);
                }
            }
          (ganesha <= 20 || ganesha >= 350) && (ganesha1 == -180) && (ganesha2 >= 80 && ganesha2 <= 95))
        */
        }

    }
}
