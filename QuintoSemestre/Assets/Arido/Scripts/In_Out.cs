using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class In_Out : MonoBehaviour
{
    public PlayableAsset fadeOutClip;


    private void Update()
    {
        if(gameObject.GetComponent<PlayableDirector>().time == gameObject.GetComponent<PlayableDirector>().duration)
        {
            Destroy(gameObject);
        }
    }
    public void fade_out()
    {
        GetComponent<PlayableDirector>().Play(fadeOutClip);
    }
}
