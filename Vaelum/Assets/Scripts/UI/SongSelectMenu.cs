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
    public Sprite descBackgroundOn;
    public GameObject descList;

    public Image songDesc;
    public Text[] description;

    public Sprite[] discRating;

    private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetString("mod", "Normal");

        //PlayerPrefs.SetInt("tutorialPlayed",1);

        playButton.GetComponent<Button>().interactable = false;
        source = gameObject.GetComponent<AudioSource>();
        if(PlayerPrefs.GetInt("tutorialPlayed") == 1)
        {
            foreach(Transform child in trackList.transform)
            {
                child.GetComponent<Button>().interactable = true;
            }
        }
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
        if (songNameString != "Tutorial" && songNameString != "Snap Crackle Bop" && songNameString != "Moonlight")
        {
            playButton.GetComponent<Button>().interactable = false;
        }
        discImage.sprite = discRating[rating];
        source.clip = Resources.Load<AudioClip>("Songs/" + songNameString);
        source.time = Random.Range(5, 60);
        source.Play();
        discSticker.sprite = Resources.Load<Sprite>("Album Covers/" + songNameString);
        fillSongDescription();


    }

    void fillSongDescription()
    {
        songDesc.sprite = descBackgroundOn;

        descList.active = true;

        description[0].text = "Rank - " + PlayerPrefs.GetString(song + "rank");
        description[1].text = "Percent - " + PlayerPrefs.GetString(song + "percentage");
        description[2].text = "Score - " + PlayerPrefs.GetString(song + "score");
        description[3].text = "Mode - " + PlayerPrefs.GetString(song + "songMode");


        if(song == "Tutorial")
        {
            description[4].text = "♫";
        }
        else if(song == "Snap Crackle Bop")
        {
            description[4].text = "♫♫";
        }
        else if (song == "Moonlight")
        {
            description[4].text = "♫♫♫";
        }


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
        PlayerPrefs.SetString("mod", "Vaelocity");
    }
    public void mementoSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, -180);
        modifierDesc.sprite = mementoDesc;
        PlayerPrefs.SetString("mod", "Memento");
    }
    public void achromaticSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, -233.526f);
        modifierDesc.sprite = achromaticDesc;
        PlayerPrefs.SetString("mod", "Achromatic");
    }
    public void normalSelected()
    {
        nob.transform.rotation = Quaternion.Euler(0, 0, 0);
        modifierDesc.sprite = normalDesc;
        PlayerPrefs.SetString("mod", "Normal");
    }


}
