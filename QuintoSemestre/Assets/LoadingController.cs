using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    public GameObject TelaCarregamento;
    public Slider BarraLoading;

    AsyncOperation async;

    public void LoadScreenExample()
    {
        StartCoroutine(LoadingScreen());
    }

    IEnumerator LoadingScreen()
    {
        TelaCarregamento.SetActive(true);
        async = SceneManager.LoadSceneAsync(0);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
           BarraLoading.value = async.progress;
            if (async.progress == 0.9f)
            {
                BarraLoading.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;

        }
    }
}
