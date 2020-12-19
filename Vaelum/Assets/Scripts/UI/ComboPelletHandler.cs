using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboPelletHandler : MonoBehaviour
{

    public Image[] pellets;

    public Sprite invinciblePellets;

    public Sprite regularPellets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void updatePellets(int combo)
    {

        combo = combo - 1;

        for (int i = 0; i < 10; i++)
        {
            pellets[i].enabled = false;
        }

        for (int i = 0; i < combo; i++)
        {
            pellets[i].enabled = true;
        }


        

        if(combo == 10)
        {
            for (int i = 0; i < 10; i++)
            {
                pellets[i].sprite = invinciblePellets;
            }
        }
        else if (combo == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                pellets[i].sprite = regularPellets;
            }
        }


    }



}
