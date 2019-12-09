using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public enum SpawnState
    {
        SPAWNING, WAITING, COUNTING;
    }

    [System Serializable]
    public class Wave()
    {
        public String name;
        public Transform enemy;
        public int count;
        public float rate;

    }

    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    private SpawnState state = SpawnState.COUNTING;

    void Satrt()
    {
        waveCountdown = timeBetweenWaves;

    }

    void Update()
    {
        if(waveCountdown <= 0)
        {
            if(state != SpawnState.SPAWNING)
            {
                //Start Spawning Wave
                StartCoroutine(SpawnWave(waves[nextWave]))
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        state = SpawnState.SPAWNING;

        for(int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave enemy)
            yeild return new WaitForSeconds(1f / wave.rate);
        }

        //Spawn
        state = SpawnState.WAITING;

        yeild break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        //Spawn Enemy
        console.Debug("Spawning Enemy: " + _enemy name);
    }

}
