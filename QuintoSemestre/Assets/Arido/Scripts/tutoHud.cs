using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutoHud : MonoBehaviour
{
    public GameObject hud;
    public static bool hudTuto = true;
    private void OnTriggerStay(Collider other)
    {

            if (other.tag == "Player" && hudTuto && Player.free)
            {
                hud.SetActive(true);
            } else hud.SetActive(false);

    }
    private void OnTriggerExit(Collider other)
    {
        hud.SetActive(false);
    }
}
