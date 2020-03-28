using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public static bool JogoPausado = false;
    public GameObject MenuPauseUI;

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
    }
    void Pause()
    {
        MenuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        JogoPausado = true;
    }
}

