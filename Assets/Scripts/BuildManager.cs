using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager Instance;
    public TurretDesign selctedTurret;

    public TurretDesign SelectedTurret
    {
        get
        {
            return selctedTurret;
        }
        set
        {
            selctedTurret = value;
        }
    }
    //if 
    public bool CanBuild
    {
        get
        {
            return SelectedTurret != null && SelectedTurret.prefab != null; 
        }
    }

    private void Awake()
    {
        Instance = this;
    }
}
