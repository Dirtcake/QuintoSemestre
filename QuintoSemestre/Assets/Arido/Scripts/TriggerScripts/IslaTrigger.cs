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
        HubSpawnManager.atual = HubSpawnManager.islamismo;
        SceneManager.LoadScene("Hub",LoadSceneMode.Single);
    }

    public void NomearLocal()
    {
       /* PlayerPrefs.SetString(HubSpawnManager.BANCOKEY, HubSpawnManager.ISLAMICOKEY);
        PlayerPrefs.Save();*/

        GetComponent<VideoPlayer>().clip = VideoClips[0];
        GetComponent<VideoPlayer>().Play();
    }
}
