using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager Instance;
    public GameObject turretPrefeb;

    public GameObject SelectedTurret
    {
        get
        {
            return turretPrefeb;
        }
        set
        {
            turretPrefeb = value;
        }
    }

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
