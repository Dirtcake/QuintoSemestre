using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MenuPause : MonoBehaviour
{
    public static bool JogoPausado = false;
    public GameObject MenuPauseUI;
    public FirstPersonController jogador;
    
  
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JogoPausado)
            {
                Resume();   
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        MenuPauseUI.SetActive(false);
       
        Time.timeScale = 1f;
        JogoPausado = false;
        jogador.pj_andando = true;
    }
    void Pause()
    {
        MenuPauseUI.SetActive(true);
      
        Time.timeScale = 0f;
        JogoPausado = true;
        jogador.pj_andando = false;
    }
}

