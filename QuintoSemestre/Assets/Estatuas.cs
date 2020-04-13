using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject estatua1, estatua2, estatua3;

    public GameObject portaprincipal;
    

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


        if ((ganesha <= 20 || ganesha >= 350) && (ganesha1 >= 170 && ganesha1 <= 180) && (ganesha2 >= 80 && ganesha2 <= 90))
        {
            portaprincipal.GetComponent<Interpolacao>().PortaPuzzle1();
        }
       
    }
}
