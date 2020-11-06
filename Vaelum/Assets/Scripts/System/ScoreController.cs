using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{



    public Text comboUI;

    public Text scoreUI;

    public Slider healthUI;


    public int combo = 1;

    public int health = 100;

    public int score = 0;

    void Start()
    {
     
    }

    void addScore(bool perfectHit)
    {

        score = score + (1 * combo);


        if (health < 100)
        {
            health = health + combo;
        }

        if (perfectHit == false)
        {
            print("OK");
        }
        else if (combo < 10)
        {
            combo++;
        }



        updateUI();

    }
     

    void missedNote()
    {

        combo = 1;

        health = health - 10;

        updateUI();

        if(health < 1)
        {

            print("loose");

        }
    }

    void updateUI()
    {

        scoreUI.text = score.ToString();

        healthUI.value = health;
        
        comboUI.text = "x" + combo.ToString();


    }


}
