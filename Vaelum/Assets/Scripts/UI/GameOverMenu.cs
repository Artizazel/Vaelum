using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{


    public GameObject discPiece;
    public GameObject retryPiece;
    public GameObject giveUpPiece;
    public GameObject repairedPiece;



    public void Retry()
    {

        discPiece.active = false;
        retryPiece.active = false;
        giveUpPiece.active = false;
        repairedPiece.active = true;

        Invoke("ReloadScene", 0.1f);

    }

    public void GiveUP()
    {

        SceneManager.LoadScene(1);

    }

    private void ReloadScene()
    {

        SceneManager.LoadScene(2);

    }


}
