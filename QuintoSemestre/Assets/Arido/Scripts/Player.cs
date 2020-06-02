using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controlador;

    float velocidade = 6;
    float gravidade = 50;
    float moveY = 0;

    bool isAgachado;
    float altura = 2;

    public static bool free = true;

    const float VELO_PADRAO = 5, VELO_CORRENDO = 8, VELO_AGACHADO = 2.5F;
    const float ALTURA_PE = 2, ALTURA_AGACHADO = 0;


    void Start()
    {
        controlador = GetComponent<CharacterController>();
        transform.position = HubSpawnManager.atual;
    }

    void Update()
    {
        if (free)
        {
            float rotY = Input.GetAxis("Mouse X") * 100;
            transform.Rotate(0, rotY * Time.deltaTime, 0);

            if (controlador.isGrounded)
            {
                moveY = 0;
                if (Input.GetKeyDown(KeyCode.Space)) moveY = 14;
            }

            moveY -= gravidade * Time.deltaTime;

            Vector3 move = Vector3.zero;
            move += Input.GetAxis("Horizontal") * transform.right * velocidade;
            move += Input.GetAxis("Vertical") * transform.forward * velocidade;
            move += moveY * Vector3.up;
            controlador.Move(move * Time.deltaTime);

            if (controlador.isGrounded)
                agachar();

            if (!isAgachado && controlador.isGrounded)
                Correr();

            controlador.height = Mathf.Lerp(controlador.height, altura, 3 * Time.deltaTime);
        }
    }

    void Correr() 
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocidade = VELO_CORRENDO;

        }
        else velocidade = VELO_PADRAO;
    }
    void agachar()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isAgachado = true;
            altura = ALTURA_AGACHADO;
            velocidade = VELO_AGACHADO;

        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isAgachado = false;
            altura = ALTURA_PE;
            velocidade = VELO_PADRAO;
        }
    }
}
