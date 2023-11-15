using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Bear;
    public Transform spawnPoint;
    public float spawnInterval = 3f;

    void Start()
    {
        // Call the SpawnEnemy method repeatedly with the specified spawn interval
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Instantiate an enemy prefab at the spawn point
        Instantiate(Bear, spawnPoint.position, spawnPoint.rotation);
    }
}
