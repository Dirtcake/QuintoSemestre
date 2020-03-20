using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

    //[SerializeField] GameObject[] triggers;

    public GameObject EstatuaMeio, EstatuaEsquerda, EstatuaDireita;

    public int tipo;

    bool camera_open, trigger_check;

    public GameObject cameraPlayer, panorama;

    bool abriu, fechou, animando = true;

    public Vector3 posicao_camera_panorama;

    private Vector3 pos_inicial, pos_final, pos_frame_inicial;

    void Start () {
        posicao_camera_panorama = new Vector3 (42.9f, 28.2f, -8.7f);

        pos_inicial = cameraPlayer.transform.position;
        pos_final = posicao_camera_panorama;
    }

    void Update () {

        //panorama.transform.position = Vector3.Lerp (pos_inicial, pos_final, Time.deltaTime);

        Movimentacao_estatuas ();

        if (Input.GetKeyDown (KeyCode.E)) {
            abriu = true;
        }
        if (Input.GetKeyDown (KeyCode.Q)) {
            fechou = true;
        }

    }

    void OnTriggerStay (Collider other) {

        if (other.tag == "Player" && camera_open == false && abriu) {

            abrir_camera ();

            abriu = false;

        }

        if (other.tag == "Player" && camera_open == true && fechou) {

            fechar_camera ();

            fechou = false;

        }
    }

    void abrir_camera () {

        cameraPlayer.SetActive (false);

        camera_open = true;
    }
    void fechar_camera () {

        cameraPlayer.SetActive (true);

        camera_open = false;
    }

    void Movimentacao_estatuas () {
        if (camera_open && Input.GetKeyDown (KeyCode.E) && tipo == 1) {
            EstatuaMeio.transform.Rotate (0, 90, 0);
            EstatuaDireita.transform.Rotate (0, 90, 0);
            EstatuaEsquerda.transform.Rotate (0, 90, 0);
        }

        if (camera_open && Input.GetKeyDown (KeyCode.E) && tipo == 2) {
            if (EstatuaEsquerda == null) {
                EstatuaDireita.transform.Rotate (0, 90, 0);
            }

            if (EstatuaDireita == null) {
                EstatuaEsquerda.transform.Rotate (0, 90, 0);
            }
        }

    }

}

/*
Click => desliga a camera do jogador
movimenta a camera do puzzle da posição do jogador até a posição pre estabelecida
Só consegue movimentar as estatuas quando chega na posição final

Click=> volta a camera pra posição do jogador 
desliga a rotação das estatuas
e liga a camera do jogador
*/