using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{

    public static int currentAmountOfNotes = 0;

    public GameObject note;

    public float spawnTime;

    float startUp = 1.375f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countdown());
        currentAmountOfNotes = 0;
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(spawnTime - startUp);

        if(currentAmountOfNotes >= 9)
        {
            currentAmountOfNotes = 1;
        }
        else
        {
            currentAmountOfNotes++;
        }
        


        Instantiate(note, gameObject.transform.position, gameObject.transform.rotation);
        
    }

    
}
