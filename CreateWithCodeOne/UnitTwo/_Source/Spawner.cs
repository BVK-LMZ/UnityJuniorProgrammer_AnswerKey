using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs; // An array to store your prefab game objects
    public Transform[] cylinders; // An array to store your cylinders
    public float spawnInterval = 2f; // Time between each spawn
    private float nextSpawnTime;
    
    void Update()
    {
        // Checks if it's time to spawn a new prefab
        if (Time.time > nextSpawnTime)
        {
            SpawnPrefab();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
    
    void SpawnPrefab()
    {
        // Randomly select a cylinder
        int randomCylinderIndex = Random.Range(0, cylinders.Length);
        Transform selectedCylinder = cylinders[randomCylinderIndex];

        // Randomly select a prefab
        int randomPrefabIndex = Random.Range(0, prefabs.Length);
        GameObject selectedPrefab = prefabs[randomPrefabIndex];

        // Instantiate the prefab at the position of the selected cylinder
        GameObject spawnedPrefab = Instantiate(selectedPrefab, selectedCylinder.position, selectedCylinder.rotation);

        // Rotate the spawned prefab to match the direction of the cylinder
        spawnedPrefab.transform.forward = selectedCylinder.forward;
    }
}