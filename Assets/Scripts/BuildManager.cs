using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
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
