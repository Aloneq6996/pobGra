using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject objectToSpawn;
    public GameObject lastToSpawn;
    public float spawnInterval = 1.0f;
    private List<int> waves = new List<int> {3, 5, 10, 15, 25};
    private int enemyCounter;
    private Vector3 spawnPosition = new Vector3(-16f, -6f, 5f);
    private int _i = 0;
    private int wave = 0;
    public bool last = false;

    private float enemyInterval = 0.6f;
    void Start()
    {
        
    }


    private void Update()
    {
        if (spawnInterval <= 0f && last == true)
        {
            SceneManager.LoadScene("winPage");
        }
        if (spawnInterval <= 0f)
        {
            Spawn();
            spawnInterval = enemyInterval;
            
            if (_i == waves[wave])
            {
                wave++;
                _i = 0;
                spawnInterval = 5f;
                if (wave >= waves.Count)
                {
                    spawnInterval = 15f;
                    last = true;
                }
            }

        }
        spawnInterval -= Time.deltaTime;
    }

    private void Spawn()
    {
        _i++;
        var enemy = Instantiate(objectToSpawn, spawnPosition, transform.rotation);
        enemy.GetComponent<EnemyHealth>().moneys = GameObject.FindGameObjectWithTag("money").GetComponent<moneys>();

    }
}