using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;


public class SplashScreenMenu : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource source;

    public AudioClip[] clips;

    private void Start()
    {
        PlayerPrefs.SetFloat("volume", 0f);

        source = gameObject.GetComponent<AudioSource>();

        source.volume = 0;

        
    }

   


    public void VaelumPressed()
    {

        SceneManager.LoadScene(1);

    }

    private void FixedUpdate()
    {

        if(source.volume < 0.6f)
        {
            source.volume = source.volume + 0.005f;
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(source.isPlaying == false)
        {
            int roll = Random.Range(0, 8);

            source.clip = clips[roll];

            source.Play();

            source.volume = 0f;
        }

    }


}
