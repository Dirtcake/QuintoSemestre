using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableMouse : MonoBehaviour
{

    public GameObject cursor;
  
    void OnEnable()
    {

        cursor.SetActive(true);
        Player.free = false;

       // Cursor.lockState = CursorLockMode.None;
       // Cursor.visible = true;
    }
    void OnDisable()
    {
        cursor.SetActive(false);
        Player.free = true;

        /*Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.free = true;*/
    }
}
