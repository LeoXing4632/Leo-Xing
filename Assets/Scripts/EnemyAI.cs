 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Transform target;
    private int pointIndex = 0;
    public float moveSpeed = 10; //enemy moving speed

    // Start is called before the first frame update
    void Start()
    {
        target = PathPoints.pathPoints[pointIndex];//moving to the pathpoint
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;//moving to the pathpoint
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);
        if(Vector3.Distance(target.position, transform.position) < 0.2f)
        {
            pointIndex++;
            if (pointIndex >= PathPoints.pathPoints.Length)
            {
                PathEnd();
                return;
            }
            target = PathPoints.pathPoints[pointIndex];
        }
    }
    private void PathEnd()//move to the end and Destroy = lose 
    {
        Destroy(gameObject);
        EnemySpawner.EnemyAlive--;
        
    }
}
