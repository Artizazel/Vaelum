using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class HitDetection : MonoBehaviour
{
    private Camera cam;



    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


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
            else if (Input.GetKey("e") && Input.GetMouseButtonDown(0) && hit.transform.tag == "n Notes" & !(Input.GetKey("w") || Input.GetKey("q")))
            {

                hit.transform.gameObject.SendMessage("clickedOn");


                Debug.Log(hit.transform.gameObject);


            }

        }


    }



}

