using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int noOfHearts;

    //Image array conatining array of hearts
    public Image[] hearts;
    //Holds full heart image
    public Sprite fullHeart;
    //Holds empty heart image
    public Sprite emptyHeart;

    // Update is called once per frame
    void Update()
    {
        //health never excedes number of hearts on screen 
        if(health > noOfHearts)
        {
            health = noOfHearts;
        }

        //Displays full hearts and empty hearts
        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else{
                hearts[i].sprite = emptyHeart;
            }
            
            if(i < noOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                 hearts[i].enabled = false;
            }
        }
    }
}
