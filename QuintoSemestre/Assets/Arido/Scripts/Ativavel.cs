using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Ativavel : MonoBehaviour
{
   
    public GameObject[] controlado_array;
    public GameObject camera_panorama;
    public FirstPersonController jogador;

   

    public Vector3 inicial;
    public Vector3 final;

    public float vel = 2f;
    public float contador_ativo;

    public bool ativo = false;
    public bool controle_de_camera = false;
    public bool vista_panorama = false;

    public void Start()
    {
          
    }
    void Update(){

        Quaternion rotacao = transform.rotation;

        if (gameObject.tag == "alavanca")
        {
            if (ativo)
            {
                rotacao = Quaternion.Slerp(rotacao, Quaternion.Euler(final), Time.deltaTime * vel);

                if (transform.rotation == Quaternion.Euler(final)) ativo = false;

            }

            else rotacao = Quaternion.Slerp(rotacao, Quaternion.Euler(inicial), Time.deltaTime * vel);
        }
        transform.rotation = rotacao;

        if (controle_de_camera){
            if (Input.GetMouseButtonDown(1))
            {
                Camera_Controle_Desativa();
            }
        }


    }

   

    public void Ativa(){
        for(int i = 0; i < controlado_array.Length; i++){ 
            if(controlado_array[i].tag == "estatua")
            {
                controlado_array[i].GetComponent<Interpolacao>().Estatua();
            }
            if (controlado_array[i].tag == "porta")
            {
                controlado_array[i].GetComponent<Interpolacao>().Porta();
            }
            if (controlado_array[i].name == "PortaPuzzle1")
            {
                controlado_array[i].GetComponent<Interpolacao>().PortaPuzzle1();
            }
        }
        if(controle_de_camera) Camera_Controle();

    }

    public void Animacao(){
        ativo = !ativo;
    }

    public void Camera_Controle()
    {
        camera_panorama.SetActive(true);
        vista_panorama = true;
        jogador.pj_andando = false;
        
    }

    public void Camera_Controle_Desativa()
    {
        camera_panorama.SetActive(false);
        vista_panorama = false;
        jogador.pj_andando = true;
    }

}
