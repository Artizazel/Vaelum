using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayKey : MonoBehaviour
{


    Image display;

    Color32 wC = new Color32(0x50, 0x5B, 0xF7, 0xFF);
    Color32 qC = new Color32(0x76, 0x00, 0x00, 0xFF); 
    Color32 eC = new Color32(0xA0, 0xFF, 0xC8, 0xFF); 
    Color sC = Color.white;



    // Start is called before the first frame update
    void Start()
    {
        display = gameObject.GetComponent<Image>();
       

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w") & !((Input.GetKey("q") || Input.GetKey("e"))))
        {

            display.color = wC;

        }
        else if (Input.GetKey("q") & !(Input.GetKey("w") || Input.GetKey("e")))
        {

            display.color = qC;

        }
        else if (Input.GetKey("e") & !(Input.GetKey("q") || Input.GetKey("w")))
        {

            display.color = eC;

        }
        else if(Input.GetKey(KeyCode.Space))
        {

            display.color = sC;

        }
        else
        {

            display.color = Color.grey;

        }


    }
}
