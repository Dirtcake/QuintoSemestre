using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class IslaTrigger : MonoBehaviour
{
    public List<VideoClip> VideoClips;



    public void trocaCena()
    {
        SceneManager.LoadScene("FinalJ2");
    }

    public void NomearLocal()
    {
        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }
}
