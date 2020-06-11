using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Playables;


public class TutoEvents : MonoBehaviour
{
    public List<VideoClip> VideoClips;

    public List<Sprite> tutoImages;
    private int indice;

    public List<PlayableAsset> fadeIn_Out;
    private PlayableDirector Timeline;
    private Image place;

    public In_Out fadeout;


    private void Start()
    {
        Timeline = GameObject.Find("TutoPlace").GetComponent<PlayableDirector>();
        place = GameObject.Find("TutoPlace").GetComponent<Image>();
    }

    public void trocaCena()
    {
        HubSpawnManager.loading = "Hub";
        SceneManager.LoadScene("Carregamento");
    }

    public void NomearLocal1()
    {
        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }

    public void NomearLocal2()
    {
        GetComponent<VideoPlayer>().clip = VideoClips[1];
        GetComponent<VideoPlayer>().Play();
    }

    public void Trocar()
    {
        Timeline.Play(fadeIn_Out[1]);

        indice++;
        Iniciar(indice);
    }

    private void Iniciar(int indice)
    {
        place.sprite = tutoImages[indice];        
        Timeline.Play(fadeIn_Out[0]);

    }

    public void sumir()
    {
        Timeline.Play(fadeIn_Out[1]);
    }

}
