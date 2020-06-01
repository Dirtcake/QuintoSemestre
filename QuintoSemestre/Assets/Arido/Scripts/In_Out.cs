using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class In_Out : MonoBehaviour
{
    public PlayableAsset fadeOutClip;
    public void fade_out()
    {
        GetComponent<PlayableDirector>().Play(fadeOutClip);
    }
}
