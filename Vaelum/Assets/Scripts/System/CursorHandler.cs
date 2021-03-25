using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHandler : MonoBehaviour
{

    Vector2 cursorPos;

    SpriteRenderer cursorSprite;

    public Sprite Q;
    public Sprite W;
    public Sprite E;
    public Sprite S;
    public Sprite Default;

    Color32 wC = new Color32(0x50, 0x5B, 0xF7, 0xFF);
    Color32 qC = new Color32(0xD6, 0x00, 0x00, 0xFF);
    Color32 eC = new Color32(0xA0, 0xFF, 0xC8, 0xFF);

    Color dC = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        cursorSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;


        if (Input.GetKey("w") & !((Input.GetKey("q") || Input.GetKey("e"))))
        {
            cursorSprite.sprite = W;
            cursorSprite.color = wC;

        }
        else if (Input.GetKey("q") & !(Input.GetKey("w") || Input.GetKey("e")))
        {
            cursorSprite.sprite = Q;
            cursorSprite.color = qC;

        }
        else if (Input.GetKey("e") & !(Input.GetKey("q") || Input.GetKey("w")))
        {
            cursorSprite.sprite = E;
            cursorSprite.color = eC;

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            cursorSprite.sprite = S;
            cursorSprite.color = Color.yellow;

        }
        else
        {
            cursorSprite.sprite = Default;
            cursorSprite.color = dC;

        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gameObject.GetComponent<Animator>().enabled = false;
            transform.localScale = new Vector3(0.8f, 0.8f);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            transform.localScale = new Vector3(1f, 1f);
            gameObject.GetComponent<Animator>().enabled = true;
        }


    }
}
