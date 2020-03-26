using UnityEngine;
using UnityEngine.UI;

public class GerenciarSom : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string MusicaPref = "MusicaPref";
    private static readonly string EfeitosPref = "EfeitosPref";
    private int firstPlayInt;
    public Slider musicaSlider, efeitosSlider;
    private float musicaFloat, efeitosFloat;
    public AudioSource musicaAudio;
    public AudioSource[] efeitosAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        
        if(firstPlayInt == 0)
        {
            musicaFloat = .25f;
            efeitosFloat = .75f;
            musicaSlider.value = musicaFloat;
            efeitosSlider.value = efeitosFloat;
            PlayerPrefs.SetFloat(MusicaPref, musicaFloat);
            PlayerPrefs.SetFloat(EfeitosPref, efeitosFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            musicaFloat = PlayerPrefs.GetFloat(MusicaPref);
            musicaSlider.value = musicaFloat;
            efeitosFloat = PlayerPrefs.GetFloat(EfeitosPref);
            efeitosSlider.value = efeitosFloat;
        }
    }
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MusicaPref, musicaSlider.value);
        PlayerPrefs.SetFloat(EfeitosPref, efeitosSlider.value);
    }
    void OnApplicationFocus(bool inFocus)
    {
        if(!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        musicaAudio.volume = musicaSlider.value;

        for(int i = 0; i < efeitosAudio.Length; i++)
        {
            efeitosAudio[i].volume = efeitosSlider.value;
        }
    }
 
}
