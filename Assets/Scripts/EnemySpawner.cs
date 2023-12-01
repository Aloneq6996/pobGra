using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 2.0f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0.0f, spawnInterval);
    }

    void SpawnObject()
    {
        // Specify the position where you want to spawn the object
        Vector3 spawnPosition = new Vector3(-16f, -6f, 5f); // Change these values to your desired position

        // Instantiate the object at the specified position and rotation
        Instantiate(objectToSpawn, spawnPosition, transform.rotation);
    }
}