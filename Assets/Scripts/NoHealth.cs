using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoHealth : MonoBehaviour
{
    private bool _isDead = false;
    public DeathMenu deathMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_isDead == true)
        {
            deathMenu.ToggleEndMenu();
        }

         Death();
    }

     private void Death()
        {
            
            if(GameObject.Find("Spaceship").GetComponent<Health>().health <= 0)
            {
                _isDead = true;
               // GetComponent<Score>().OnDeath();
            }
        }
}
