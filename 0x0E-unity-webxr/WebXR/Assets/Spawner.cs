using UnityEngine;

public class ProceduralObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab; // The object to spawn
    public int numberOfObjects = 5; // Number of objects to spawn
    public Vector3 alleyStartPosition; // Start position of the alley
    public Vector3 alleyEndPosition; // End position of the alley
    public float spawnHeight = 0.5f; // Height at which objects should spawn

    void Start()
    {
        GenerateObjects();
    }

    void GenerateObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Randomly determine the position within the alley
            float randomX = Random.Range(alleyStartPosition.x, alleyEndPosition.x);
            float randomZ = Random.Range(alleyStartPosition.z, alleyEndPosition.z);
            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);

            // Instantiate the object at the random position
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
