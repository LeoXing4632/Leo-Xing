using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretDesign standardTurret;
    public TurretDesign ArrowTurret;
    public TurretDesign Turret3;
 public void OnPurseStandardTurret()
    {
        Debug.Log("BUY StandardTurret");
        BuildManager.Instance.SelectedTurret = standardTurret;
    }
    public void OnPurseArrowTurret()
    {
        Debug.Log("BUY ArrowTurret");
        BuildManager.Instance.SelectedTurret = standardTurret;
    }
    public void OnPurseTurret3()
    {
        Debug.Log("BUY Turret3");
        BuildManager.Instance.SelectedTurret = standardTurret;
    }
}
