using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{

    public static int currentAmountOfNotes = 0;

    public GameObject note;

    private Object aNote;

    public float spawnTime;

    float startUp = 1.45f;


    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(countdown());
        currentAmountOfNotes = 0;
    }

    void VaelocityActive()
    {
        spawnTime = spawnTime / 1.5f;
        //startUp = startUp / 1.5f;
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds((spawnTime + 2) - startUp);

        //if(currentAmountOfNotes >= 9)
        //{
        //    currentAmountOfNotes = 1;
        //}
        //else
        //{
            currentAmountOfNotes++;
        //}
        

        if(PlayerPrefs.GetString("mod") == "Achromatic")
        {
            aNote = Resources.Load("A Note");
            Instantiate(aNote, gameObject.transform.position, gameObject.transform.rotation);
        }
        else
        {
            Instantiate(note, gameObject.transform.position, gameObject.transform.rotation);
        }
        
        
    }

    
}
