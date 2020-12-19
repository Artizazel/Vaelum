using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{

    public GameObject pauseScreen;

    bool paused = false;

    AudioSource song;

    // Start is called before the first frame update
    void Start()
    {
        song = GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>();

        song.volume = PlayerPrefs.GetFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if(SceneManager.GetActiveScene().name == "Play Scene")
            {

                pauseGame();

            }

            
        }


    }



    public void pauseGame()
    {

        if (paused == false)
        {

            paused = true;

            Time.timeScale = 0;

            pauseScreen.active = true;

            song.Pause();

        }
        else
        {
            paused = false;


            Time.timeScale = 1;

            pauseScreen.active = false;

            song.Play();
        }

    }


}
