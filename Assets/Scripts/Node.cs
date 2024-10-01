using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer render;
    private Color initColor;
    public Color hoverColor = Color.blue;//Change color
    public Vector3 offset = new Vector3 (0, 1.5f,0);
    
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        initColor = render.material.color;
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        if (BuildManager.Instance.SelectedTurret == null) return; //when play not select turret doe3s not change color 
        render.material.color = hoverColor;//change color as the mouse touch it
    }
    private void OnMouseExit()
    {
        render.material.color = initColor;//change back to the normal color 
    }
    private void OnMouseDown()
    {
        if(BuildManager.Instance.SelectedTurret == null) return;
        Debug.Log("loding the turret");
        Instantiate (BuildManager.Instance.SelectedTurret, transform.position + offset, Quaternion.identity);//building the Turret on the nodes

    }
}
