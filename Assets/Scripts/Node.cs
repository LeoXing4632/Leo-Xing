using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer render;
    private Color initColor;
    public Color hoverColor = Color.blue;//Change color
    public Vector3 offset = new Vector3 (0, 0.5f,0);
    public GameObject turretPrefab;
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
        render.material.color = hoverColor;//change color as the mouse touch it
    }
    private void OnMouseExit()
    {
        render.material.color = initColor;//change back to the normal color 
    }
    private void OnMouseDown()
    {
        Debug.Log("loding the turret");
        Instantiate (turretPrefab, transform.position + offset, Quaternion.identity);//building the Turret on the nodes

    }
}
