using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("r2");
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
