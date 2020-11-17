using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public void Retry()
    {

        SceneManager.LoadScene(1);

    }

    public void GiveUP()
    {

        SceneManager.LoadScene(0);

    }


}
