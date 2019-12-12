using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public DeathMenu deathMenu;
    public static int score;
    private bool isDead = false;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "Score: " + score;

        if(isDead == true)
        {
            return;
        }
    }

    public void Death()
    {
        isDead = true; 
        deathMenu.ToggleEndMenu(score);
    }
}
