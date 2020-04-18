using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ControleObjetivo : MonoBehaviour
{
    [SerializeField] GameObject[] l_trigger;
    [SerializeField] Sprite[] l_objetivo;
    [SerializeField] VideoPlayer[] l_videos;

    public RawImage fundoVideo;
    public AudioClip somLugar;

    public AudioClip som;
    public int indice;
    AudioSource sons;    
    public GameObject objetivos;

    public float alpha ;

    void Start()
    {
        indice = 0;
        sons = GetComponent<AudioSource>();
     //   fundoVideo = GetComponent<RawImage>();

        fundoVideo.CrossFadeAlpha(alpha, 0f, true);
    }


    private void OnTriggerEnter(Collider other)
    {
        /* for ( int x = indice; indice < l_trigger.Length; indice++)
         {
          //   Debug.Log(indice);
          //  Debug.Log("bateu");
              l_trigger[indice].SetActive(false);
              objetivos.GetComponent<Image>().sprite = l_objetivo[indice];
              sons.clip = som;
             sons.Play();

             indice++;
             break;
         }*/
        if (other.CompareTag("estado") && indice < l_trigger.Length)
        {
            
            Debug.Log("bateu");


            objetivos.GetComponent<Image>().sprite = l_objetivo[indice];
            fundoVideo.CrossFadeAlpha(1f, 0f, true);
            fundoVideo.texture = l_videos[indice].texture;
            l_videos[indice].Play();
           
            sons.clip = som;
            sons.Play();

            l_trigger[indice].SetActive(false);
            other.gameObject.SetActive(false);
            indice++;
        }
    }
}
