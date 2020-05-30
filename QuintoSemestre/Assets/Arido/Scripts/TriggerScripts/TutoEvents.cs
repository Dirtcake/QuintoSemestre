using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class TutoEvents : MonoBehaviour
{
    public List<VideoClip> VideoClips;

    public void trocaCena()
    {
        SceneManager.LoadScene("Hub");
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
}
