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

    public AudioSource perfectHitSound;

    public AudioSource okayHitSound;

    public AudioSource missedHitSound;

    Color32 qC = new Color32(0x6A, 0x2F, 0x39, 0xFF);


    void Start()
    {
        noteList = GameObject.Find("Note List");



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
            okayHitSound.Play();

            print("OK");
            if(invincible == true)
            {
                numOfHitNotes++;
                invincible = false;
                notePercent = ((numOfHitNotes / noteCount) * 100);
                healthUIFill.color = qC;
            }
            else if (invincible == false)
            { 
                numOfHitNotes = numOfHitNotes + 0.6f;
                health = health - 5;
            }

            combo = 1;

        }
        else
        {
            perfectHitSound.Play();
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
            healthUIFill.color = Color.white;

        }

        updateUI();

    }
     

    void missedNote()
    {


        missedHitSound.Play();

        combo = 1;
        if (invincible == true)
        {
            numOfHitNotes++;

            notePercent = ((numOfHitNotes / noteCount) * 100);
            invincible = false;
            healthUIFill.color = qC;

        }
        else
        {

            notePercent = ((numOfHitNotes / noteCount) * 100);

            

            health = health - 10;            

            

            if (health < 1)
            {

                SceneManager.LoadScene(2);

            }

        }

        updateUI();

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
