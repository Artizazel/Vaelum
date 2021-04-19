using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{

    public static int currentAmountOfNotes = 0;

    public GameObject note;

    private Object mNote;

    private Object aNote;

    private GameObject mementoDisplay;

    private Object mementoIndicator;

    public float spawnTime;

    float startUp = 1.45f;

    float indicatorStartUp = 6f;

    private float startDelay = 2;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetString("mod", "Memento");

        

            if (PlayerPrefs.GetString("mod") == "Memento")
        {

            if (name.Substring(0,8) == "Q Origin")
            {
                mNote = Resources.Load("A Note Q");
                mementoIndicator = Resources.Load("Memento Indicators/Q Ind");
            }
            else if (name.Substring(0, 8) == "W Origin")
            {
                mNote = Resources.Load("A Note W");
                mementoIndicator = Resources.Load("Memento Indicators/W Ind");
            }
            else if (name.Substring(0, 8) == "E Origin")
            {
                mNote = Resources.Load("A Note E");
                mementoIndicator = Resources.Load("Memento Indicators/E Ind");
            }
            else if (name.Substring(0, 8) == "S Origin")
            {
                mNote = Resources.Load("A Note S");
                mementoIndicator = Resources.Load("Memento Indicators/S Ind");
            }

            startDelay = 6;
            mementoDisplay = GameObject.Find("Memento Display");
            StartCoroutine(mementoCountdown());

           
        }
            

        StartCoroutine(countdown());
        currentAmountOfNotes = 0;
    }

    void VaelocityActive()
    {
        spawnTime = spawnTime / 1.5f;
        //startUp = startUp / 1.5f;
    }

    void DecelerateActive()
    {
        spawnTime = spawnTime / 0.9f;
        //startUp = startUp / 1.5f;
    }

    IEnumerator mementoCountdown()
    {
        yield return new WaitForSeconds((spawnTime + startDelay) - indicatorStartUp);

        Instantiate(mementoIndicator, mementoDisplay.transform);

    }

        IEnumerator countdown()
    {
        yield return new WaitForSeconds((spawnTime + startDelay) - startUp);

        currentAmountOfNotes++;
        
        

        if(PlayerPrefs.GetString("mod") == "Achromatic")
        {
            aNote = Resources.Load("A Note");
            Instantiate(aNote, gameObject.transform.position, gameObject.transform.rotation);
        }
        else if(PlayerPrefs.GetString("mod") == "Memento")
        {
            Instantiate(mNote, gameObject.transform.position, gameObject.transform.rotation);
        }
        else
        {
            Instantiate(note, gameObject.transform.position, gameObject.transform.rotation);
        }
        
        
    }

    
}
