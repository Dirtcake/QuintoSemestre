using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

    //[SerializeField] GameObject[] triggers;

    public GameObject EstatuaMeio, EstatuaEsquerda, EstatuaDireita;

    public int tipo;

    bool camera_open, trigger_check;

    public GameObject cameraPlayer, panorama;
    private bool entrou, saiu;

    void Start () {

    }

    void Update () {

        // Open_camera ();
        movimentacao_nacamera ();

        if (Input.GetKeyDown (KeyCode.E)) entrou = true;
        if (Input.GetKeyDown (KeyCode.Q)) saiu = true;

    }

    void OnTriggerStay (Collider other) {

        if (other.tag == "Player" && camera_open == false && entrou) {

            abrir_camera ();
            camera_open = true;

            entrou = false;
        }
        if (other.tag == "Player" && camera_open == true && saiu) {
            fechar_camera ();
            camera_open = false;

            saiu = false;
        }
    }

    void Open_camera () {
        if (trigger_check && camera_open == false && Input.GetKeyDown (KeyCode.Q)) {
            abrir_camera ();
        }
        if (trigger_check && camera_open == true && Input.GetKeyDown (KeyCode.Q)) {
            fechar_camera ();
        }
    }

    void movimentacao_nacamera () {
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

    void abrir_camera () {
        panorama.SetActive (true);
        cameraPlayer.SetActive (false);

        camera_open = true;
    }
    void fechar_camera () {
        panorama.SetActive (false);
        cameraPlayer.SetActive (true);

        camera_open = false;
    }

}