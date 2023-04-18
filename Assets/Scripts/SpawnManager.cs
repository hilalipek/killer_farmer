using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRange = 20.0f;

    
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating ("SpawnRandomAnimal", 0, 1.5f);
    }

    // Update is called once per frame
    void update()
    {
       
        
    }

    void SpawnRandomAnimal()
    {
        
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, 20);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }
}
