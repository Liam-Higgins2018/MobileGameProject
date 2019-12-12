using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoHealth : MonoBehaviour
{
    private bool _isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_isDead == true)
        {
            return;
        }

        Death();
    }

     private void Death()
        {
            
            if(GameObject.Find("Spaceship").GetComponent<Health>().health <= 0)
            {
                _isDead = true;
               GetComponent<ScoreManager>().Death();
              // deathMenu.ToggleEndMenu(score);
            }
        }
}
