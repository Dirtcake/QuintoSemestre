using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Playables;

public class cristaoVideo : MonoBehaviour
{
    public VideoClip video;
    public In_Out fadeout;
    public void NomearLocal()
    {
        GetComponent<VideoPlayer>().clip = video;
        GetComponent<VideoPlayer>().Play();
    }
    public void trocaCena()
    {
        HubSpawnManager.atual = HubSpawnManager.cristao;
        SceneManager.LoadScene("Hub",LoadSceneMode.Single);
    }

}
