using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus: MonoBehaviour
{
    public int StartMoney = 500;
    public static int Money;
    public int StartLives = 3; // chu shi sheng ming zhi
    public static int Lives;
    // Start is called before the first frame update
    void Start()
    {
        Money = StartMoney;
        Lives = StartLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
