using System.Collections;
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

        Invoke("EndLevel", songLength);

    }

    void EndLevel()
    {

        SceneManager.LoadScene(0);

    }

    void Update()
    {

        progressBar.value = song.time;


        

    }
    
}
