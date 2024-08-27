using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static int EnemyAlive;
    public Wave[] waveEnemy;
    public Transform spawnPoint;
    private int waveIndex;
    public float spawnInterval = 1f;
    private float countDown;
    // Start is called before the first frame update
    void Start()
    {
        countDown = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyAlive > 0)
        {
            return;
        }

        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            countDown = spawnInterval;
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        StartCoroutine(WaveEnemy());
       
    }
    IEnumerator WaveEnemy()
    {
        if(waveIndex >= waveEnemy.Length)
        {
            yield break;
        }
        Wave wave= waveEnemy[waveIndex];

        EnemyAlive = wave.count;
        for (int i = 0; i < wave.count; i++) 
        {
            Instantiate(wave.enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(1/wave.rate);
        }
        waveIndex++;
    }
}
