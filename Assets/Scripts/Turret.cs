using UnityEngine;
using System.Collections.Generic;

public class Turret : MonoBehaviour
{
    public float fireRate = 1f;
    public float range = 10f;
    public string enemyTag = "enemy";

    public Transform shootingPoint;
    public string audioClipName = "pew";

    private float fireCountdown = 0f;
    private List<Transform> enemies = new List<Transform>();
    private AudioSource audioSource;
    private AudioClip audioClip;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag(enemyTag);
        foreach (var enemyObject in enemyObjects)
        {
            enemies.Add(enemyObject.transform);
        }
        audioClip = Resources.Load<AudioClip>("Audio/" + audioClipName);
        if (audioClip == null)
        {
            Debug.LogError("Plik audio nie został znaleziony: " + audioClipName);
        }
    }

    void Update()
    {
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
                        enemyHealth.TakeDamage(10);
                        
                        if (audioSource != null && audioClip != null)
                        {
                            audioSource.clip = audioClip;
                            audioSource.Play();
                        }
                        else
                        {
                            Debug.LogError("Komponent AudioSource lub Audio Clip nie został poprawnie skonfigurowany.");
                        }
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