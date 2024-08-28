using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float InitHealth = 100;
    private float currenthealth;
    internal static EnemyHealth enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = InitHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(float amount)
    {
        currenthealth -= amount;
        if(currenthealth <= 0 )
        {
            EnemySpawner.EnemyAlive--;
            Destroy(gameObject);
            
        }

    }
}
