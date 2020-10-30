using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayKey : MonoBehaviour
{


    Image display;

    Color32 wC = new Color32(0x61, 0x3B, 0xCC, 0xFF);
    Color32 qC = new Color32(0x6A, 0x2F, 0x39, 0xFF);
    Color32 eC = new Color32(0x5D, 0xC8, 0x9D, 0xFF);




    // Start is called before the first frame update
    void Start()
    {
        display = gameObject.GetComponent<Image>();
       

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w") & !(Input.GetKey("q") || Input.GetKey("e")))
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
        else
        {

            display.color = Color.grey;

        }


    }
}
