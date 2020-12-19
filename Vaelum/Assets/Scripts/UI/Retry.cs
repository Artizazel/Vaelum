using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;

        print("r1");
        SceneManager.LoadScene(6);
    }


   

    // Update is called once per frame
    void Update()
    {
        
    }
}
