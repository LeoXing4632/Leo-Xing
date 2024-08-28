using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer render;
    private Color initColor;
    private Color hoverColor = Color.gray;//change color when after modeling
    public GameObject turretPrefab;
    // Start is called before the first frame update
    void Start()
    {
        initColor = render.material.color;
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        render.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        render.material.color = initColor;
    }
    private void OnMouseDown()
    {
        Debug.Log("loding the turret");
        Instantiate (turretPrefab, transform.position, Quaternion.identity);
    }
}
