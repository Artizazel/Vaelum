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
        SceneManager.LoadScene(0);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void adjustVolume()
    {

        song.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volumeSlider.value);

    }



}
