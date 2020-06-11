using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaLoading : MonoBehaviour
{
    [SerializeField]
    private Image Progresso;

 
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(LoadAsyncOperation());
    }


    IEnumerator LoadAsyncOperation()
    {
        if (HubSpawnManager.loading == null)
        {
            AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);

            while (gameLevel.progress < 1)
            {
                Progresso.fillAmount = gameLevel.progress;
                yield return new WaitForEndOfFrame();
            }
        } else
        {
            AsyncOperation gameLevel = SceneManager.LoadSceneAsync(HubSpawnManager.loading);

            while (gameLevel.progress < 1)
            {
                Progresso.fillAmount = gameLevel.progress;
                yield return new WaitForEndOfFrame();
            }
        }


        
    }

}
