using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    private int addScore;
    public DeathMenu deathMenu;
     void OnTriggerEnter2D(Collider2D target)
    {

        if(target.tag == "Asteroid")
        {
            //ScoreManager.score += 10;
            addScore = 10;
        }

        else if(target.tag == "Enemy")
        {
            addScore = 20;
        }

    
     ScoreManager.score += addScore;
    }
}
