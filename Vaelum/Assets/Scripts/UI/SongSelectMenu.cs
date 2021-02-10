using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SongSelectMenu : MonoBehaviour
{
    public static string song;

    public Text songName;
    public GameObject playButton;
    public GameObject nob;
    public GameObject disc;
    public GameObject trackList;
    public Image modifierDesc;
    bool discActive = false;
    bool rightHeld = false;
    bool leftHeld = false;
    int trackPosition = 0;
    public static int rating;
    public Image discImage;
    public Image discSticker;

    public Sprite normalDesc;
    public Sprite vaelocityDesc;
    public Sprite mementoDesc;
    public Sprite achromaticDesc;

    public Sprite[] discRating;

    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        playButton.GetComponent<Button>().interactable = false;
        source = gameObject.GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        
        if(discActive)
        {
            disc.transform.Rotate(0, 0, -0.5f);
        }

        if(Input.GetKey("[") && Input.GetKey("z"))
        {
            PlayerPrefs.DeleteAll();

        }


        if(rightHeld)
        {
            print(trackList.transform.childCount);
            if(trackPosition < (trackList.transform.childCount-6) * 250)
            {
                trackPosition += 20;
                trackList.transform.Translate(-20, 0, 0);
            }
        }
        if (leftHeld)
        {
            if (trackPosition > 0)
            {
                trackPosition += -20;
                trackList.transform.Translate(20, 0, 0);
            }
        }
    }


    public void moveRight()
    {

        rightHeld = true;

    }

    public void moveLeft()
    {
        
        leftHeld = true;
    }

    public void letGo()
    {
        rightHeld = false;
        leftHeld = false;
    }


    public void loadSong(string songNameString)
    {
        song = songNameString;
        songName.text = songNameString;
        disc.SetActive(true);
        discActive = true;
        playButton.GetComponent<Button>().interactable = true;
        discImage.sprite = discRating[rating];
        source.clip = Resources.Load<AudioClip>("Songs/" + songNameString);
        source.time = Random.Range(5, 60);
        source.Play();
        discSticker.sprite = Resources.Load<Sprite>("Album Covers/" + songNameString);
        
    }



    public void play()
    {
        SceneManager.LoadScene(2);
    }

    public void loadSplashScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void vaelocitySelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, -124.793f);
        modifierDesc.sprite = vaelocityDesc;
        PlayerPrefs.SetInt("mod", 1);
    }
    public void mementoSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, -180);
        modifierDesc.sprite = mementoDesc;
        PlayerPrefs.SetInt("mod", 2);
    }
    public void achromaticSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, -233.526f);
        modifierDesc.sprite = achromaticDesc;
        PlayerPrefs.SetInt("mod", 3);
    }
    public void normalSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, 0);
        modifierDesc.sprite = normalDesc;
        PlayerPrefs.SetInt("mod", 0);
    }


}
