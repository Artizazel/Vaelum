using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class NoteController : MonoBehaviour
{

    private bool perfectHit = false;

    public GameObject scoreController;

    private Renderer noteRenderer;

    public GameObject okayTimingText;

    public GameObject perfectTimingText;

    public GameObject missedTimingText;

    GameObject tutorial;

    bool tutorialActive = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreController = GameObject.Find("Score Controller");
        noteRenderer = GetComponent<Renderer>();


        transform.Translate(0, 0, (SpawnNote.currentAmountOfNotes));


        //gameObject.transform.GetComponentInChildren<Text>().text = SpawnNote.currentAmountOfNotes.ToString();

        if (tutorial = GameObject.Find("Tutorial(Clone)"))
        {
            tutorialActive = true;
        }


    }



    void clickedOn()
    {
        if(perfectHit == true)
        {
            if (tutorialActive == true)
            {
                tutorial.SendMessage("perfect");
            }
            Instantiate(perfectTimingText, transform.position, transform.rotation);
        }
        else
        {
            if (tutorialActive == true)
            {
                tutorial.SendMessage("okay");
            }
            Instantiate(okayTimingText, transform.position, transform.rotation);
        }

        scoreController.SendMessage("addScore", perfectHit);
        ScoreController.noteCount++;

        Destroy(gameObject);

    }


    void perfectNote()
    {

        perfectHit = true;

    }

    void perfectColour()
    {

        if (gameObject.tag == "Q notes")
        {


            noteRenderer.material.color = Color.red;
        }
        else if (gameObject.tag == "W notes")
        {
            noteRenderer.material.color = Color.blue;
        }
        else if (gameObject.tag == "E notes")
        {
            noteRenderer.material.color = Color.cyan;
        }
        else if (gameObject.tag == "S notes")
        {
            noteRenderer.material.color = Color.grey;
        }


    }

    void missNote()
    {
        if(tutorialActive == true)
        {
            tutorial.SendMessage("miss");
        }


        Instantiate(missedTimingText, transform.position, transform.rotation);
        ScoreController.noteCount++;
        scoreController.SendMessage("missedNote");
        Destroy(gameObject);
    }

}
