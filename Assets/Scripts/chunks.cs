using System.Collections.Generic;
using UnityEngine;

public class chunks : MonoBehaviour
{
    [SerializeField] float[] lanes = { -3, 0, 3 };
    [SerializeField] GameObject fence;
    [SerializeField] GameObject coin;

    private List<int> availableLanes = new List<int> { 0, 1, 2 };

    private void Start()
    {
        // Safe Zone: Don't spawn obstacles in the first 40 meters
        if (transform.position.z < 40) return;

        // Spawn the first fence explicitly in a random lane
        int firstFenceLaneIndex = Random.Range(0, availableLanes.Count);
        int firstLane = availableLanes[firstFenceLaneIndex];
        Vector3 firstFencePosition = new Vector3(lanes[firstLane], transform.position.y, transform.position.z);
        Instantiate(fence, firstFencePosition, Quaternion.identity, transform);
        availableLanes.RemoveAt(firstFenceLaneIndex);

        // Determine number of remaining fences to spawn - max 1 more fence to ensure total is 2 fences max
        int fencesToSpawn = Random.Range(0, 2); // 0 or 1

        List<int> freeLanes = new List<int>(availableLanes);

        for (int i = 0; i < fencesToSpawn; i++)
        {
            if (freeLanes.Count <= 0) break;

            int randomLaneIndex = Random.Range(0, freeLanes.Count);
            int selectedLane = freeLanes[randomLaneIndex];
            freeLanes.RemoveAt(randomLaneIndex);

            Vector3 spawnPosition = new Vector3(lanes[selectedLane], transform.position.y, transform.position.z);
            Instantiate(fence, spawnPosition, Quaternion.identity, transform);
        }

        // Update available lanes after fences spawned
        availableLanes = freeLanes;

        // Spawn coin in one of the remaining lanes
        SpawnCoin();
    }

    private void SpawnCoin()
    {
        if (availableLanes.Count == 0) return;

        int availableLane = availableLanes[0];
        Vector3 spawnPosition = new Vector3(lanes[availableLane], transform.position.y, transform.position.z);
        Instantiate(coin, spawnPosition, Quaternion.identity, transform);
    }
}
