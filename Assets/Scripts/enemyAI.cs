using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    private Pathing pathing;
    public int currCheckpoint = 0;
    public float speed;

    void Start()
    {
        pathing = GetComponent<Pathing>();
    }

    void Update()
    {
        if (pathing != null && pathing.CheckPoints != null && pathing.CheckPoints.Count > 0)
        {
            List<Transform> checkpoints = pathing.CheckPoints;
            print(checkpoints);
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
                // Handle reaching the end of the path (optional)
            }
        }
        
    }
}