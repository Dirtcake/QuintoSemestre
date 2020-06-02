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
        SceneManager.LoadScene("Palacio_Islamico",LoadSceneMode.Single);
    }

    public void CarregarCristao()
    {
        SceneManager.LoadScene("Palacio_Cristao", LoadSceneMode.Single);
    }

    public void CarregarHindu()
    {
        SceneManager.LoadScene("Palacio_Hindu_Final", LoadSceneMode.Single);
    }

    public void carregarFinal()
    {
        SceneManager.LoadScene("Quarto", LoadSceneMode.Single);

    }



}
