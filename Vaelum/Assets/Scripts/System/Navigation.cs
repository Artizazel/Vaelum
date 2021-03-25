using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Navigation : MonoBehaviour
{

    public GameObject pauseScreen;

    bool paused = false;

    AudioSource song;

    public AudioMixer mixer;

    public SpriteRenderer background;

    

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(Resources.Load("Lists/" + SongSelectMenu.song));

        setSong();

        mixer.SetFloat("Vol", PlayerPrefs.GetFloat("volume"));

        print(SongSelectMenu.song);

        background.sprite = Resources.Load<Sprite>("Album Covers/" + SongSelectMenu.song);

        if(PlayerPrefs.GetString("mod") == "Vaelocity")
        {
            GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Vaelocity/" + SongSelectMenu.song + " VaeMod");

            //song.pitch = 1.5f;

            GameObject[] notes = GameObject.FindGameObjectsWithTag("Origin");

            for (int i = 0; i < notes.Length; i++)
            {
                notes[i].SendMessage("VaelocityActive");
            }

        }



    }

    public void setSong()
    {
        song = GameObject.FindGameObjectWithTag("NoteList").GetComponent<AudioSource>();
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

            if (song != null)
            {
                song.Pause();
            }
        }
        else
        {
            paused = false;

            Cursor.visible = false;

            //if (PlayerPrefs.GetString("mod") == "Vaelocity")
            //{
            //    Time.timeScale = 1.5f;
            //}
            //else
            //{
            Time.timeScale = 1f;
            //}

            pauseScreen.active = false;

            if(song != null)
            {
                song.Play();
            }
            
        }

    }


}
