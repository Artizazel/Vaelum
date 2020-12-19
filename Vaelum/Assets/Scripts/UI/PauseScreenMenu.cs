using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseScreenMenu : MonoBehaviour
{

    private AudioSource song;

    public Slider volumeSlider;

    private void Start()
    {

        song = GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>();

        volumeSlider.value = song.volume;
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

        song.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volumeSlider.value);

    }



}
