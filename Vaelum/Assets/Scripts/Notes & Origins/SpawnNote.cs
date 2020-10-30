using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNote : MonoBehaviour
{

    public GameObject note;

    public float spawnTime;

    float startUp = 2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(spawnTime - startUp);

        Instantiate(note, gameObject.transform.position, gameObject.transform.rotation);
    }

    
}
