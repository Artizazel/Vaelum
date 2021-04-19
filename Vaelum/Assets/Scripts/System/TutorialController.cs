using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{

    public GameObject songController;
    public Text prompt;
    public GameObject Wnote;
    public GameObject Enote;
    public GameObject Qnote;
    public GameObject Snote;
    public GameObject[] arrow;

    int tutorialPos = 1;

    public Canvas tutCanvas;

    bool perfectHit = false;
    bool lateHit = false;
    bool okayHit = false;
    bool missHit = false;
    bool noteClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        part();
        tutCanvas.worldCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(noteClicked == true)
        {
            part();
        }
    }

    void part()
    {

        if (tutorialPos == 1)
        {
            if (noteClicked == false)
            {
                prompt.text = "Hold down 'W' and click on the blue note\nTry to click it just as the outer layer hits the inner layer";
                Instantiate(Wnote);
            }
            else if (perfectHit == true)
            {
                prompt.text = "Perfect! Well done, you hit the note at the right time";
                tutorialPos++;
                perfectHit = false;
                Invoke("part", 4f);
            }
            else if (okayHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit early\nTry again";
                okayHit = false;
                Instantiate(Wnote);
            }
            else if (lateHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit late\nTry again";
                lateHit = false;
                Instantiate(Wnote);
            }
            else if (missHit == true)
            {
                prompt.text = "You missed the note\nTry again\nHold down 'W' and click on the blue note";
                missHit = false;
                Instantiate(Wnote);
            }
            noteClicked = false;
        }
        else if (tutorialPos == 2)
        {
            if (noteClicked == false)
            {
                prompt.text = "This Time\nHold down 'E' and click on the light green note";
                Instantiate(Enote);
            }
            else if (perfectHit == true)
            {
                prompt.text = "Perfect again! One standard note left";
                tutorialPos++;
                perfectHit = false;
                Invoke("part", 4f);
            }
            else if (okayHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit early\nTry again";
                okayHit = false;
                Instantiate(Enote);
            }
            else if (lateHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit late\nTry again";
                lateHit = false;
                Instantiate(Enote);
            }
            else if (missHit == true)
            {
                prompt.text = "You missed the note\nTry again\nHold down 'E' and click on the light green note";
                missHit = false;
                Instantiate(Enote);
            }
            noteClicked = false;
        }
        else if (tutorialPos == 3)
        {
            if (noteClicked == false)
            {
                prompt.text = "Hold down 'Q' and click on the dark red note";
                Instantiate(Qnote);
            }
            else if (perfectHit == true)
            {
                prompt.text = "Perfect! Now this next note is a little different";
                tutorialPos++;
                perfectHit = false;
                Invoke("part", 4f);
            }
            else if (okayHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit early\nTry again";
                okayHit = false;
                Instantiate(Qnote);
            }
            else if (lateHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit late\nTry again";
                lateHit = false;
                Instantiate(Qnote);
            }
            else if (missHit == true)
            {
                prompt.text = "You missed the note\nTry again\nHold down 'Q' and click on the dark red note";
                missHit = false;
                Instantiate(Qnote);
            }
            noteClicked = false;
        }
        else if (tutorialPos == 4)
        {
            if (noteClicked == false)
            {
                prompt.text = "Simply hit space as the note closes, no need to click.\nYour mouse doesn't need to be anywhere near the note";
                Instantiate(Snote);
            }
            else if (perfectHit == true)
            {
                prompt.text = "Perfect!\nThose are all the notes you need to worry about";
                tutorialPos++;
                perfectHit = false;
                Invoke("part", 4f);
            }
            else if (okayHit == true)
            {
                prompt.text = "Too early\nremember you don't need to move your mouse\nJust hit space at the right time";
                okayHit = false;
                Instantiate(Snote);
            }
            else if (lateHit == true)
            {
                prompt.text = "So close, but you hit the note a little bit late\nTry again";
                lateHit = false;
                Instantiate(Snote);
            }
            else if (missHit == true)
            {
                prompt.text = "You missed the note\nremember you don't need to move your mouse\nJust hit space at the right time";
                missHit = false;
                Instantiate(Snote);
            }
            noteClicked = false;
        }
        else if (tutorialPos == 5)
        {

            prompt.text = "Lastly is the HUD";
            tutorialPos++;
            Invoke("part", 2f);

        }
        else if (tutorialPos == 6)
        {
            arrow[0].SetActive(true);
            prompt.text = "This is your health";
            tutorialPos++;
            Invoke("part", 3f);

        }
        else if (tutorialPos == 7)
        {
            prompt.text = "If you hit a note early/late or miss one it will go down\nIf you hit a note perfectly it will increase";
            tutorialPos++;
            Invoke("part", 7f);
        }
        else if (tutorialPos == 8)
        {
            arrow[0].SetActive(false);
            arrow[1].SetActive(true);
            prompt.text = "This is your note indicator\nit shows you which note is being held down\nGive it a try now";
            tutorialPos++;
            Invoke("part", 8f);
        }
        else if (tutorialPos == 9)
        {
            arrow[1].SetActive(false);
            arrow[2].SetActive(true);
            prompt.text = "This is your combo meter";
            tutorialPos++;
            Invoke("part", 2f);
        }
        else if (tutorialPos == 10)
        {
            prompt.text = "Every perfect hit you make will increase your combo\nEvery miss or early hit will reduce your combo to 0";
            tutorialPos++;
            Invoke("part", 8f);
        }
        else if (tutorialPos == 11)
        {
            GameObject.Find("hFill").GetComponent<Image>().color = Color.white;
            prompt.text = "Your combo maxes out at 10\nIf you get 10 combo your health will turn white\nAllowing you to miss or early hit without affecting health or rating";
            tutorialPos++;
            Invoke("part", 12f);
        }
        else if (tutorialPos == 12)
        {
            arrow[2].SetActive(false);
            arrow[3].SetActive(true);
            GameObject.Find("hFill").GetComponent<Image>().color = new Color32(0x6A, 0x2F, 0x39, 0xFF);
            prompt.text = "Up here is your progress bar";
            tutorialPos++;
            Invoke("part", 3f);
            
        }
        else if (tutorialPos == 13)
        {
           
            prompt.text = "At the moment it is paused\nIt will show you how far through a song you are";
            tutorialPos++;
            Invoke("part", 5f);

        }
        else if (tutorialPos == 14)
        {
            arrow[3].SetActive(false);
            arrow[4].SetActive(true);
            prompt.text = "And this is your song rating\nYou'll have to figure this one out for yourself";
            tutorialPos++;
            Invoke("part", 7f);

        }
        else if (tutorialPos == 15)
        {
            arrow[4].SetActive(false);
            prompt.text = "Now that you know the basics\nTry using what you've learned in time with music";
            tutorialPos++;
            Invoke("part", 7f);

        }
        else if (tutorialPos == 16)
        {
            prompt.text = "";
            Instantiate(songController);
            GameObject.Find("Navigation / Initialisation").SendMessage("setSong");
            tutorialPos++;
            Invoke("endTutorial", 50f);
        }

    }

    void endTutorial()
    {
        prompt.text = "Well done! All songs are now unlocked";
        PlayerPrefs.SetInt("tutorialPlayed",1);
    }


    void perfect()
    {
        perfectHit = true;
        noteClicked = true;
    }

    void late()
    {
        lateHit = true;
        noteClicked = true;
    }

    void okay()
    {
        okayHit = true;
        noteClicked = true;
    }

    void miss()
    {
        missHit = true;
        noteClicked = true;
    }

}
