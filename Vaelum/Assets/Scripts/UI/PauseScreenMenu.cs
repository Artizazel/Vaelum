using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;


public class PauseScreenMenu : MonoBehaviour
{

    private AudioSource song;
    

    public Slider volumeSlider;

    public AudioMixer mixer;


    private void Start()
    {
        song = GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>();
        mixer.SetFloat("Vol", PlayerPrefs.GetFloat("volume"));
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }


    public void Exit()
    {
        SceneManager.LoadScene(1);
    }
    public void Retry()
    {
        SceneManager.LoadScene(5);
    }

    public void adjustVolume()
    {

        mixer.SetFloat("Vol",volumeSlider.value);
        PlayerPrefs.SetFloat("volume", volumeSlider.value);


    }



}
