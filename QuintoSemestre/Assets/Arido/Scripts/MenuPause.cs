using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool JogoPausado = false;
    public GameObject MenuPauseUI;
    public FirstPersonController jogador;

    Ativavel vista;
  
    

    void Start()
    {
        vista = GetComponent<Ativavel>();
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

    public void Resume()
    {
        MenuPauseUI.SetActive(false);
       
        Time.timeScale = 1f;
        JogoPausado = false;
        
        Player.free = true;
       

        

    }
    void Pause()
    {
        MenuPauseUI.SetActive(true);
      
        Time.timeScale = 0f;
        JogoPausado = true;
        Player.free = false;
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
   
}

