﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    //Gets trigger on colision
    private void OnTriggerEnter2D(Collider2D target)
    {
         if(target.tag =="Player")
         {
            GameObject.Find("Spaceship").GetComponent<Health>().health -= 1;
            Debug.Log("Hit");
         }
         Debug.Log("Oh");
    }
}
