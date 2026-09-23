using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] int numToSpawn = 10;
    [SerializeField] int waitPerSpawn = 1;
    [SerializeField] float spawnWidth = 3f;
    [SerializeField] float startDelay = 3f; // Delay before first spawn
    [SerializeField] GameObject obstacleParent;

    [SerializeField] GameObject spawnSourceModel;
    [SerializeField] float spawnHeight = 10f;
    private GameObject spawnSourceInstance;

    private void Start()
    {
        if (spawnSourceModel != null)
        {
            Vector3 startPos = new Vector3(transform.position.x, transform.position.y + spawnHeight, transform.position.z);
            spawnSourceInstance = Instantiate(spawnSourceModel, startPos, Quaternion.identity);
        }

        /*
        for (int i = 0; i < numToSpawn; i++)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
        }
        */

        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()  
    {
        // Wait for the safe zone delay
        yield return new WaitForSeconds(startDelay);

        while (true)
        {
            yield return new WaitForSeconds(waitPerSpawn);
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
            
            float randomX = Random.Range(-spawnWidth, +spawnWidth);
            float spawnY = transform.position.y;

            if (spawnSourceInstance != null)
            {
                // Update spawn height to match the source model
                spawnY = spawnSourceInstance.transform.position.y;
                
                // Move the source model to the spawn X position so it looks like it dropped the obstacle
                Vector3 sourcePos = spawnSourceInstance.transform.position;
                sourcePos.x = randomX;
                spawnSourceInstance.transform.position = sourcePos;
            }

            Vector3 spawnPosition = new Vector3(randomX, spawnY, transform.position.z);
            Instantiate(obstacle, spawnPosition, Random.rotation,obstacleParent.transform);
            numToSpawn--;
        }
    }
}
