using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutoEvents : MonoBehaviour
{
public void trocaCena()
    {
        SceneManager.LoadScene("Hub");
    }
}
