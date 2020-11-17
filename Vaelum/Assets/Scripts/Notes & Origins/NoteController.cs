﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class NoteController : MonoBehaviour
{

    private bool perfectHit = false;

    public GameObject scoreController;

    private Renderer noteRenderer;

    


    // Start is called before the first frame update
    void Start()
    {
        scoreController = GameObject.Find("Score Controller");
        noteRenderer = GetComponent<Renderer>();

     
        gameObject.transform.GetComponentInChildren<Text>().text = SpawnNote.currentAmountOfNotes.ToString();
        
         

    }



    void clickedOn()
    {

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
        ScoreController.noteCount++;
        scoreController.SendMessage("missedNote");
        Destroy(gameObject);
    }

}
