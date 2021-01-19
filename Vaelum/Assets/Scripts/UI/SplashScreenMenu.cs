using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class SplashScreenMenu : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {
        PlayerPrefs.SetFloat("volume", 0f);       


    }


    public void VaelumPressed()
    {

        SceneManager.LoadScene(1);

    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


}
