using UnityEngine;
using System.Collections.Generic;

public class Turret : MonoBehaviour
{
    public float fireRate = 1f;
    public float range = 6f;
    public string enemyTag = "enemy";

    public Transform shootingPoint;

    private float fireCountdown = 0f;
    private List<Transform> enemies = new List<Transform>();


    void Start()
    {

    }

    void Update()
    {
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag(enemyTag);
        foreach (var enemyObject in enemyObjects)
        {
            enemies.Add(enemyObject.transform);
        }
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        foreach (var enemy in enemies)
        {
            if (enemy != null)
            {
                float distance = Vector3.Distance(transform.position, enemy.position);
                if (distance <= range)
                {
                    EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
                    if (enemyHealth != null)
                    {
                        enemyHealth.TakeDamage(15);
                        break;
                    }
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}