﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTiming : MonoBehaviour
{
    GameObject note;


    private void Start()
    {
        note = gameObject.transform.parent.gameObject;
    }


    public void perfectedNote()
    {

        note.SendMessage("perfectNote");

        

    }

    public void missedNote()
    {

        note.SendMessage("missNote");

    }
}
