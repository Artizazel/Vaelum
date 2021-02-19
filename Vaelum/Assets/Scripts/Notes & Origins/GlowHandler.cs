using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (transform.parent.tag == "Q notes")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (transform.parent.tag == "W notes")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if (transform.parent.tag == "E notes")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(0x39, 0xE5, 0x82, 0xFF);
        }
        else if (transform.parent.tag == "S notes")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
