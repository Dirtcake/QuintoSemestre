using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour {

    //[SerializeField] GameObject[] triggers;

    public GameObject EstatuaMeio, EstatuaEsquerda, EstatuaDireita;

    public int tipo;

    bool camera_open, trigger_check;

    public GameObject cameraPlayer, panorama;
    public Image interacao_e;

    void Start () {
        interacao_e = GetComponent<Image>();
           
    }

    void Update () {

       // Open_camera ();
        movimentacao_nacamera ();

    }

  
    void OnTriggerStay (Collider other) {

        interacao_e.enabled = true;

        if (other.tag == "Player" && camera_open == false && Input.GetKeyDown (KeyCode.E)) {

            abrir_camera();
            camera_open = true;
            //interacao_e.enabled = false;
        }
        if (other.tag == "Player" && camera_open == true && Input.GetKeyDown (KeyCode.Q)) {
            fechar_camera();
            camera_open = false;
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
       // if(other.tag == "Player") interacao_e.enabled = false;
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