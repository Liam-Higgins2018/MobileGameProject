using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float min_Y = -4.2f;
    public float max_Y = 4.2f;
    public GameObject[] Asteroid;
    public GameObject enemy;

    public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", timer);
    }

    void SpawnEnemies()
    {
        float pos_Y = Random.Range(min_Y, max_Y);
        Vector3 temp = transform.position;
        temp.y = pos_Y;

        if(Random.Range(0, 2) > 0)
        {
            Instantiate(Asteroid[Random.Range(0, Asteroid.Length)], temp, Quaternion.identity);
        }
        else{
            Instantiate(enemy, temp, Quaternion.Euler(0f, 0f, 90f));
        }

        Invoke("SpawnEnemies", timer);
    }
}
