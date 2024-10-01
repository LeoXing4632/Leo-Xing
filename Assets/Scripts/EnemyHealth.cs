using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float InitHealth = 100;// enemy Hp
    private float currenthealth;//Current blood level
    internal static EnemyHealth enemyHp;
    public Image hpBar; // health bar 

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = InitHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(float amount)//When the blood level is less than or equal to 0, it is directly destroyed.
    {
        currenthealth -= amount;
        hpBar.fillAmount = currenthealth/ InitHealth;
        if(currenthealth <= 0 )
        {
            EnemySpawner.EnemyAlive--;
            Destroy(gameObject);
            
        }

    }
}
