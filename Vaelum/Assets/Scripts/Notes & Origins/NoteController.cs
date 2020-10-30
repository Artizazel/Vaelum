using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

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
    }



    void clickedOn()
    {
        scoreController.SendMessage("addScore", perfectHit);

        print("hit");

        Destroy(gameObject);

    }


    void perfectNote()
    {

        perfectHit = true;

        if(gameObject.tag == "Q notes")
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

    }

    void missNote()
    {
        scoreController.SendMessage("missedNote");
        Destroy(gameObject);
    }

}
