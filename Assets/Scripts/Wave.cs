using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]//add each wave of enemies
public class Wave//How many types of enemy
{
    public GameObject enemyPrefab;
    public int count;
    public float rate;
}
