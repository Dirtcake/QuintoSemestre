using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class HubEvents : MonoBehaviour
{
    public List<VideoClip> VideoClips;


  public void NomearLocal()
    {
        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }




    public void CarregarIslamico()
    {
        HubSpawnManager.loading = "Palacio_Islamico";
        SceneManager.LoadScene("Carregamento",LoadSceneMode.Single);
    }

    public void CarregarCristao()
    {
        HubSpawnManager.loading = "Palacio_Cristao";
        SceneManager.LoadScene("Carregamento", LoadSceneMode.Single);
    }

    public void CarregarHindu()
    {
        HubSpawnManager.loading = "Palacio_Hindu_Final";
        SceneManager.LoadScene("Carregamento", LoadSceneMode.Single);
    }

    public void carregarFinal()
    {
        HubSpawnManager.loading = "Quarto";
        SceneManager.LoadScene("Carregamento", LoadSceneMode.Single);
    }



}
