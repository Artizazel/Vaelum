using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineHandler : MonoBehaviour
{

    private Vector3 target;

    private float dist;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void setTarget(Vector3 targ)
    {

        target = new Vector3 ((transform.position.x + (targ.x - transform.position.x) /2), (transform.position.y + (targ.y - transform.position.y) / 2), 1);

        transform.position = target;

        dist = Vector3.Distance(targ, transform.parent.transform.position);

        transform.localScale = new Vector3(dist * 2f ,transform.localScale.y);
    }

    void setColour(Color noteColor)
    {
        gameObject.GetComponent<SpriteRenderer>().color = noteColor;
    }



}
