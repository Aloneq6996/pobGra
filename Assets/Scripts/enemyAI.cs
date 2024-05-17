using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public int currCheckpoint = 0;
    public float speed;


    void Start()
    {

    }

    void Update()
    {

        List<Transform> checkpoints = pathManager.Instance.Path;
        
        float step = speed * Time.deltaTime;

        if (currCheckpoint < checkpoints.Count)
        {

            transform.position = Vector2.MoveTowards(transform.position, checkpoints[currCheckpoint].position, step);

            if (Vector2.Distance(transform.position, checkpoints[currCheckpoint].position) < 0.01f)
            {
                currCheckpoint += 1;
            }
        }
        else
        {
            
        }
    
        
    }
}