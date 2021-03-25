using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class HitDetection : MonoBehaviour
{
    private Camera cam;

    GameObject[] sNotes;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            sNotes = GameObject.FindGameObjectsWithTag("S notes");

            sNotes[0].SendMessage("clickedOn");
        }





        if (hit.collider != null)
        {

            if (Input.GetKey("w") && Input.GetMouseButtonDown(0) && hit.transform.tag == "W notes" & !(Input.GetKey("q") || Input.GetKey("e")))
            {

                hit.transform.gameObject.SendMessage("clickedOn");


                Debug.Log(hit.transform.gameObject);


            }
            else if (Input.GetKey("q") && Input.GetMouseButtonDown(0) && hit.transform.tag == "Q notes" & !(Input.GetKey("w") || Input.GetKey("e")))
            {

                hit.transform.gameObject.SendMessage("clickedOn");


                Debug.Log(hit.transform.gameObject);


            }
            else if (Input.GetKey("e") && Input.GetMouseButtonDown(0) && hit.transform.tag == "E notes" & !(Input.GetKey("w") || Input.GetKey("q")))
            {

                hit.transform.gameObject.SendMessage("clickedOn");


                Debug.Log(hit.transform.gameObject);


            }
            else if (Input.GetMouseButtonDown(0) && hit.transform.tag == "A notes")
            {

                hit.transform.gameObject.SendMessage("clickedOn");


                Debug.Log(hit.transform.gameObject);


            }


        }


    }

    void SpaceNoteSpawned()
    {




    }



}

