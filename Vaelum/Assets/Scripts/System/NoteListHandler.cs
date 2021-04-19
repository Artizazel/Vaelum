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

    public static List<Vector3> notes;

    public static List<int> noteObjects;

    private int startDelay = 2;

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetString("mod") == "Memento")
        {
            startDelay = 6;
        }

            notes = new List<Vector3>();

        noteObjects = new List<int>();

        progressBar = GameObject.Find("Progress Bar").GetComponent<Slider>();

        song = GetComponent<AudioSource>();

        songLength = song.clip.length + startDelay + 1;

        progressBar.maxValue = songLength;

        print(song.name);

        Invoke("EndLevel", songLength);

        Time.timeScale = 1;
      
        Invoke("playSong", startDelay);

    }

    void EndLevel()
    {
        print(song.name);
        PlayerPrefs.SetFloat(song.name + "percent", ScoreController.notePercent);
        PlayerPrefs.SetFloat(song.name + "score", ScoreController.score);
        SceneManager.LoadScene(3);
    }

    void playSong()
    {
        song.Play();
    }

    void Update()
    {

        progressBar.value = song.time;
        

    }
    
}
