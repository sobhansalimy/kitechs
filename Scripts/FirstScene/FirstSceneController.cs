using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneController : MonoBehaviour
{
    public GameObject Loading;
    public GameObject aboutUs;
    public GameObject OptionMenu;
    public GameObject MainMenu;
    public GameObject SoundON;
    public GameObject SoundOFF;
    public GameObject MusicON;
    public GameObject MusicOFF;
    public AudioSource BackgroundMusic;
    public Image LoadingImg;
    public Text progresssText;


    private bool isMuted;
    private bool isMutedMusic;

    void Start()
    {
        Loading.SetActive(false);
        MainMenu.SetActive(true);
        OptionMenu.SetActive(false);
        aboutUs.SetActive(false);

        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;
        MusicON.SetActive(true);



    }

    
    void Update()
    {


        SoundON.SetActive(!isMuted);
        SoundOFF.SetActive(isMuted);


        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
    public void GoToARScene()
    {
        Loading.SetActive(true);
        StartCoroutine(LoadingScene());
    }
    public void aboutus()
    {
        OptionMenu.SetActive(false);
        MainMenu.SetActive(false);
        aboutUs.SetActive(true);
    }
    public void aboutusexit()
    {
        OptionMenu.SetActive(false);
        aboutUs.SetActive(false);
        MainMenu.SetActive(true);
    }


    public void OptionOpen()
    {
        aboutUs.SetActive(false);
        MainMenu.SetActive(false);
        OptionMenu.SetActive(true);
    }


    public void OptionExit()
    {
        aboutUs.SetActive(false);
        OptionMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void MuteSounds()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
    }


    public void MuteMusic()
    {
        BackgroundMusic.Pause();
        MusicON.SetActive(false);
        MusicOFF.SetActive(true);
    }

    public void ONMuteMusic()
    {
        BackgroundMusic.Play();
        MusicON.SetActive(true);
        MusicOFF.SetActive(false);
    }

    IEnumerator LoadingScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("ARScene");
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            LoadingImg.fillAmount = progress;
            progresssText.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
        
    }
}
