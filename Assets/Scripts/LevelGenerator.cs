using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] GameObject chunkParent;
    [SerializeField] int intialChunkAmount = 10;
    [SerializeField] int chunkLength = 10;
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float maxSpeed = 20;
    [SerializeField] float acceleration = 0.1f;

    List<GameObject> chunks = new List<GameObject>();
    //GameObject[] chunks = new GameObject[10];

    private void Start()
    {
        SpawnChunk();
    }

    private void Update()
    {
        // Increase speed over time
        if (moveSpeed < maxSpeed)
        {
            moveSpeed += acceleration * Time.deltaTime;
        }

        MoveChunk();
    }

    private void SpawnChunk()
    {
        for (int i = 0; i < intialChunkAmount; i++)
        {
            float chunkZ;
            chunkZ = (i * chunkLength) + transform.position.z;


            Vector3 chunkPos = new Vector3(transform.position.x, transform.position.y, chunkZ);
            GameObject newChunk = Instantiate(chunkPrefab, chunkPos, Quaternion.identity, chunkParent.transform);
            chunks.Add(newChunk);
        }
    }

    private void SpawnNewChunk()
    {
        float chunkZ;
        chunkZ = chunks[chunks.Count - 1].transform.position.z + chunkLength;
        Vector3 chunkPos = new Vector3(transform.position.x , transform.position.y , chunkZ);
        GameObject newChunk = Instantiate(chunkPrefab, chunkPos , Quaternion.identity, chunkParent.transform);
        chunks.Add(newChunk);
    }

    private void MoveChunk()
    {
        for(int i = 0;i < chunks.Count;i++)
        {
            GameObject chunk = chunks[i];
            chunks[i].transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
            if (chunks[i].transform.position.z <= Camera.main.transform.position.z - chunkLength)
            {
                chunks.Remove(chunk);
                Destroy(chunk);
                SpawnNewChunk();
            }
        }

        //foreach (GameObject chunk in chunks)
        //{
        //    chunk.transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
        //}
    }
}

