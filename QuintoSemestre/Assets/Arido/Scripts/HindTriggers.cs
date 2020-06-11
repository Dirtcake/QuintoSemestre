using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;



public class HindTriggers : MonoBehaviour
{
    public List<VideoClip> VideoClips;


    public void NomearLocal()
    {
        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }

    public void trocaCena()
    {
        HubSpawnManager.atual = HubSpawnManager.hindu;
        HubSpawnManager.loading = "Hub";
        SceneManager.LoadScene("Carregamento", LoadSceneMode.Single);
    }
}
