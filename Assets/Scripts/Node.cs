using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    private Renderer render;
    private Color initColor;
    public Color hoverColor = Color.blue;//Change color
    public Vector3 offset = new Vector3(0, 1.5f, 0);
    public Color notEnoughMoneyColor;


    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        initColor = render.material.color;
       
    }

    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        if (!BuildManager.Instance.CanBuild) return; //when play not select turret doe3s not change color 
        if(BuildManager.Instance.HasEnoughMoney)
        {
            render.material.color = notEnoughMoneyColor;
            return;
        }
        render.material.color = hoverColor;//change color as the mouse touch it
    }
    private void OnMouseExit()
    {
        render.material.color = initColor;//change back to the normal color 
    }
    private void OnMouseDown()
    {
        if(EventSystem.current.IsPointerOverGameObject()) return;
        if (!BuildManager.Instance.CanBuild) return;
        Debug.Log("loding the turret");
       
        if(PlayerStatus.Money >=BuildManager.Instance.SelectedTurret.cost)
        {
            BuildTurret();

        }
        else
        {
            Debug.Log("no money to build");
        }
        
        

    }
    private Vector3 GetPositon()
    {
        return transform.position + offset;
    }
    //creat turret
    public void BuildTurret()
    {
        //Money decrease 
        PlayerStatus.Money -= BuildManager.Instance.SelectedTurret.cost;
        Instantiate(BuildManager.Instance.SelectedTurret.prefab, GetPositon(), Quaternion.identity);//building the Turret on the nodes
    }
  
}
