﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoteListHandler : MonoBehaviour
{

    private Slider progressBar;

    private AudioSource song;

    float songLength;

    // Start is called before the first frame update
    void Start()
    {
        

        progressBar = GameObject.Find("Progress Bar").GetComponent<Slider>();

        song = GetComponent<AudioSource>();

        songLength = song.clip.length + 3;

        progressBar.maxValue = songLength;

        print(song.name);

        Invoke("EndLevel", songLength);

        Time.timeScale = 1;

    }

    void EndLevel()
    {
        print(song.name);
        PlayerPrefs.SetFloat(song.name + "percent", ScoreController.notePercent);
        PlayerPrefs.SetFloat(song.name + "score", ScoreController.score);
        SceneManager.LoadScene(3);
    }

    void Update()
    {

        progressBar.value = song.time;


        

    }
    
}
