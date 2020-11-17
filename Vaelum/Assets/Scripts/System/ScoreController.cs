using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{



    public Text comboUI;

    public Text scoreUI;

    public Text percentageUI;

    public Slider healthUI;

    public Image healthUIFill;

    public GameObject noteList;

    public static float noteCount = 1;

    public float numOfHitNotes = 1;

    public float notePercent = 100;

    bool invincible = false;

    public int combo = 1;

    public int health = 100;

    public int score = 0;

    

    void Start()
    {
        noteList = GameObject.Find("Note List");

        //noteCount = noteList.transform.childCount;

        updateUI();
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
            if(invincible == true)
            {
                numOfHitNotes++;

                notePercent = ((numOfHitNotes / noteCount) * 100);
            }
            { invincible = false;
                healthUIFill.color = Color.red;
                numOfHitNotes = numOfHitNotes + 0.5f;
            }

        }
        else
        {

            numOfHitNotes++;

            notePercent = ((numOfHitNotes / noteCount) * 100);

            if (combo < 10)
            {
                combo++;
            }
            
        }


        if(combo == 10)
        {

            invincible = true;
            healthUIFill.color = Color.yellow;

        }

        updateUI();

    }
     

    void missedNote()
    {

        if(invincible == true)
        {
            numOfHitNotes++;

            notePercent = ((numOfHitNotes / noteCount) * 100);
            invincible = false;
            healthUIFill.color = Color.red;

        }
        else
        {

            notePercent = ((numOfHitNotes / noteCount) * 100);

            combo = 1;

            health = health - 10;            

            updateUI();

            if (health < 1)
            {

                SceneManager.LoadScene(2);

            }

        }
        
    }

    void updateUI()
    {

        scoreUI.text = score.ToString();

        healthUI.value = health;

        comboUI.text = "x" + combo.ToString();

        if (notePercent > 100)
        {
            percentageUI.text = "100" + "%";
        }
        else
        {
            percentageUI.text = notePercent.ToString() + "%";
        }

    }
    


}
