using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HubEvents : MonoBehaviour
{
    public List<VideoClip> VideoClips;


  public void NomearLocal()
    {

        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }
}
