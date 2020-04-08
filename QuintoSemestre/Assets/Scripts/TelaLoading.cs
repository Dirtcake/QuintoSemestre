using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaLoading : MonoBehaviour
{
    [SerializeField]
    private Image Progresso;
 
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync(2);

        while (gameLevel.progress < 1)
        {
            Progresso.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }
        
    }

}
