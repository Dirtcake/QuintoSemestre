using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativavel : MonoBehaviour
{
   
    public GameObject[] controlado_array;

   public Quaternion estatua1;
   public Quaternion estatua2;
   public Quaternion estatua3;

    public Vector3 inicial;
    public Vector3 final;
    public float vel;
    bool ativo = false;
   

    public void Start()
    {
        vel = 2f;  
    }
    void Update()
    {
        Quaternion rotacao = transform.rotation;

        if (gameObject.tag == "alavanca")
        {
            if (ativo)
            {
                rotacao = Quaternion.Slerp(rotacao, Quaternion.Euler(final), Time.deltaTime * vel);

                if (transform.rotation == Quaternion.Euler(final))
                    ativo = false;
            }

            else rotacao = Quaternion.Slerp(rotacao, Quaternion.Euler(inicial), Time.deltaTime * vel);
        }
        transform.rotation = rotacao;

    }

    public void Ativa()
    {

        for(int i = 0; i < controlado_array.Length; i++){ 
            if(controlado_array[i].tag == "estatua")
            {
                if (controlado_array[i].name == "ganesha") estatua1 = controlado_array[i].transform.rotation;
                else if (controlado_array[i].name == "ganesha (1)") estatua2 = controlado_array[i].transform.rotation;
                else if (controlado_array[i].name == "ganesha (2)") estatua3 = controlado_array[i].transform.rotation;
                controlado_array[i].GetComponent<Interpolacao>().Estatua();
            }
            if (controlado_array[i].tag == "porta")
            {
                controlado_array[i].GetComponent<Interpolacao>().Porta();
            }
        }



    }

    public void Animacao()
    {
        ativo = !ativo;
    }

   


}

public class PuzzleTutor : Ativavel
{

     void Update()
    {
        if (estatua1.y == 0 && estatua2.y == 180 && estatua3.y == 90)
        {
            print("as três estátuas estão alinhadas");
        }
    }
}