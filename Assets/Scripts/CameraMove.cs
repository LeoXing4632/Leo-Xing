using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 50;//WASD Speed of the movement 
    public float scrollSpeed = 200;//speed of zoom in and out 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;//moing to the left by using press A
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right  * moveSpeed * Time.deltaTime;//moing to the right by using press D
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;//moing to the forward by using press W
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;//moing to the back by using press S
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 160f) 
        {
            transform.position += Vector3.up * scroll * scrollSpeed * Time.deltaTime;//zoom in and zoom out
        }
    }
}
