using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    //Gets trigger on colision
    private void OnTriggerEnter2D(Collider2D target)
    {
        GameObject.Find("Spaceship").GetComponent<Health>().health -= 1;
    }
}
