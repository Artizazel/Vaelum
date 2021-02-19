using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{


    public Sprite bronze;
    public Sprite silver;
    public Sprite gold;
    public Sprite plat;
    public Sprite diamond;
    public Sprite vae;

    private GameObject updatePelletHUD;

    public Image ratingIndicator;

    public Text comboUI;

    public Text scoreUI;

    public Text percentageUI;

    public Slider healthUI;

    public Image healthUIFill;

    public GameObject noteList;

    public static float noteCount = 1;

    public float numOfHitNotes = 1;

    public static float notePercent = 100;

    bool invincible = false;

    public int combo = 1;

    public int health = 100;

    public static int score = 0;

    public AudioSource perfectHitSound;

    public AudioSource okayHitSound;

    public AudioSource missedHitSound;

    Color32 qC = new Color32(0x76, 0x00, 0x00, 0xFF);


    void Start()
    {

        notePercent = 100;
        score = 0;
        numOfHitNotes = 1;
        noteCount = 1;

        updatePelletHUD = GameObject.Find("Combo Bar");

        noteList = GameObject.Find("Note List");

        


        updateUI();
    }

    void addScore(int hitType)
    {

        score = score + (10 * combo);


        if (health < 100)
        {
            health = health + combo;
        }

        if (hitType != 0)
        {
            okayHitSound.Play();

            print("OK");
            if(invincible == true)
            {
                numOfHitNotes++;
                invincible = false;
                //notePercent = ((numOfHitNotes / noteCount) * 100);
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

            if (combo < 11)
            {
                combo++;
            }
            
        }


        if(combo == 11)
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

            //notePercent = ((numOfHitNotes / noteCount) * 100);
            invincible = false;
            healthUIFill.color = qC;

        }
        else
        {

            notePercent = ((numOfHitNotes / noteCount) * 100);

            

            health = health - 10;            

            

            if (health < 1)
            {

                SceneManager.LoadScene(4);

            }

        }

        updateUI();

    }

    void updateUI()
    {


        updatePelletHUD.SendMessage("updatePellets", combo);

        scoreUI.text = score.ToString();

        healthUI.value = health;

        comboUI.text = "x" + combo.ToString();

        if (notePercent > 100)
        {
            notePercent = 100;
        }

        updateRating(notePercent);

    }

    void updateRating(float percent)
    {



        if (percent >= 100)
        {
            ratingIndicator.sprite = vae;
        }
        else if (percent > 95)
        {
            ratingIndicator.sprite = diamond;
        }
        else if (percent > 90)
        {
            ratingIndicator.sprite = plat;
        }
        else if (percent > 80)
        {
            ratingIndicator.sprite = gold;
        }
        else if (percent >= 70)
        {
            ratingIndicator.sprite = silver;
        }
        else if (percent < 70)
        {
            ratingIndicator.sprite = bronze;
        }



    }
    


}
