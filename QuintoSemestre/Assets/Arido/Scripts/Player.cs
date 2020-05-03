using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController controlador;

    float velocidade = 6;
    float gravidade = 50;
    float moveY = 0;


    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
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
    }
}
