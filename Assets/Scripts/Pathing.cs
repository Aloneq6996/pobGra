using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
    public List<Transform> CheckPoints;
    public List<Transform> Checkpoints
    {
        get { return CheckPoints; }
    }

    void Start()
    {
        int checkpointNum = 0;
        while (true)
        {
            GameObject checkpointObject = GameObject.Find(checkpointNum.ToString());

            if (checkpointObject == null)
            {
                break;
            }

            Transform checkpointTransform = checkpointObject.transform;
            CheckPoints.Add(checkpointTransform);
            checkpointNum++;
        }
        print(CheckPoints);
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
    }
}