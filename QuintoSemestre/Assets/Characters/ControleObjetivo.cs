using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ControleObjetivo : MonoBehaviour
{
    [SerializeField] GameObject[] l_trigger;
    [SerializeField] Sprite[] l_objetivo;
    [SerializeField] GameObject[] l_triggerV;
    [SerializeField] VideoPlayer[] l_videos;

    int indice;
    int indiceV;

    public RawImage fundoVideo;
    float alpha;

    public AudioClip somLugar;
    public AudioClip som;
    AudioSource sons; 
    
    public GameObject objetivos;

    

    void Start()
    {
        sons = GetComponent<AudioSource>();

        fundoVideo.CrossFadeAlpha(alpha, 0f, true);
    }


    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("estado") && indice < l_trigger.Length)
        {
            objetivos.GetComponent<Image>().sprite = l_objetivo[indice];
          
            sons.clip = som;
            sons.Play();

            l_trigger[indice].SetActive(false);
            other.gameObject.SetActive(false);
            indice++;
        }
        else if (other.CompareTag("lugar") && indiceV < l_triggerV.Length)
        {

            fundoVideo.CrossFadeAlpha(1f, 0f, true);
            fundoVideo.texture = l_videos[indiceV].texture;
            l_videos[indiceV].Play();

            l_triggerV[indiceV].SetActive(false);
            other.gameObject.SetActive(false);
            indiceV++;
        }
    }
}
