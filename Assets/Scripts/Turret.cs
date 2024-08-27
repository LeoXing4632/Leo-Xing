using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float range = 5;
    public string enemyTag = "Enemy";
    public Transform target;
    public Transform partRotate;
    public float rotSpeed = 10;
    public float bulletRate = 2f;
    private float countDown = 0;    
    public Transform bulletPoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdataTarget", 0, 0.5f);
        countDown = 1/bulletRate;
    }


    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        LockTarget();
        countDown -= Time.deltaTime;
        if(countDown <= 0)
        {
            Debug.Log("bulletPoint");
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            countDown = 1 / bulletRate;
        }
    }
   private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
    private void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float minDistance = Mathf.Infinity;
        Transform nearestEnemy = null;
        foreach (var enemy in enemies)
        {
            float distance = Vector3.Distance(enemy.transform.position, transform.position);
            if (distance < minDistance )
            {
                minDistance = distance;
                nearestEnemy = enemy.transform;
            }
        
        }
        if(minDistance < range)
        {
            target = nearestEnemy;
        }
        else
        {
            target = null;
        }
    }
    private void LockTarget()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dir);
        Quaternion lerpRot = Quaternion.Lerp(partRotate.rotation, rotation, Time.deltaTime * rotSpeed);
        partRotation.rotation = Quaternion.Euler(new Vector3(0, lerpRot.eulerAngles.y, 0));
    }
    //rotation of the turret when there is a mode
}
