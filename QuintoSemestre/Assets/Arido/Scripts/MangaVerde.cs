using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangaVerde : MonoBehaviour
{
    public GameObject animafinal;
    void Start()
    {
        Debug.Log("Voces ja comeram Manga Verde Com sal?");
    }

    public void FINAL()
    {
        Instantiate(animafinal);
    }
}
