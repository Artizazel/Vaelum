using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSong : MonoBehaviour
{

    GameObject songSelectCanvas;

    // Start is called before the first frame update
    void Start()
    {
        songSelectCanvas = GameObject.Find("Song Select Canvas");
    }

    public void loadSong()
    {

        PlayerPrefs.SetString("currentSong", gameObject.name);



        if (PlayerPrefs.GetFloat(gameObject.name + "rating") == 100)
        {
            SongSelectMenu.rating = 6;
        }
        else if (PlayerPrefs.GetFloat(gameObject.name + "rating") > 95)
        {
            SongSelectMenu.rating = 5;
        }
        else if (PlayerPrefs.GetFloat(gameObject.name + "rating") > 90)
        {
            SongSelectMenu.rating = 4;
        }
        else if (PlayerPrefs.GetFloat(gameObject.name + "rating") > 80)
        {
            SongSelectMenu.rating = 3;
        }
        else if (PlayerPrefs.GetFloat(gameObject.name + "rating") > 70)
        {
            SongSelectMenu.rating = 2;
        }
        else if (PlayerPrefs.GetFloat(gameObject.name + "rating") <= 70)
        {
            SongSelectMenu.rating = 1;
        }

        if (PlayerPrefs.GetFloat(gameObject.name + "rating") == 0)
        {
            SongSelectMenu.rating = 0;
        }



        songSelectCanvas.SendMessage("loadSong", gameObject.name);

        
    }
}
