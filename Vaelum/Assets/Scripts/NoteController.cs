using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NoteController : MonoBehaviour
{

    private bool perfectHit = false;

    GameObject scoreController;

    

    // Start is called before the first frame update
    void Start()
    {
        scoreController = GameObject.Find("Score Controller");
    }



    void clickedOn()
    {

        scoreController.SendMessage("addScore", perfectHit);
        

    }


    void perfectNote()
    {

        perfectHit = true;
        Debug.Log("Prefect");

    }

    void missNote()
    {
        scoreController.SendMessage("missedNote");
        Destroy(gameObject);
    }

}
