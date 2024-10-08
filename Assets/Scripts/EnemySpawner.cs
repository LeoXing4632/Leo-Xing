using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public static int EnemyAlive;//Enemy alive
    public Wave[] waveEnemy;//
    public Transform spawnPoint;//Enemy generation location
    private int waveIndex;//Number of enemies generated per wave
    public float spawnInterval = 1f;//Time between enemy generation
    private float countDown;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        countDown = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyAlive > 0)//Not generated if the number 0 is exceeded
        {
            return;
        }

        countDown -= Time.deltaTime;
        countDown = Mathf.Clamp(countDown, 0, Mathf.Infinity);
        string time = string.Format("{0:00.00}", countDown);
        timerText.text = time;
        if (countDown <= 0)
        {
            countDown = spawnInterval;
            SpawnEnemy();//Enemy generation at the end of the countdown
        }
    }
    private void SpawnEnemy()//Enemy Generation
    {
        StartCoroutine(WaveEnemy());
       
    }
    IEnumerator WaveEnemy()//Without spawning an enemy, the second enemy waits 0.5 seconds.
    {
        if(waveIndex >= waveEnemy.Length)
        {
            yield break;
        }
        Wave wave= waveEnemy[waveIndex];//Record the number of enemy survivors

        EnemyAlive = wave.count;
        for (int i = 0; i < wave.count; i++) 
        {
            Instantiate(wave.enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(1/wave.rate);
        }
        waveIndex++;//Each wave increases the number of enemies
    }
}
